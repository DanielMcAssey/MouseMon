using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Timers;
using System.Linq;

namespace MouseMon
{
    public class MouseMonitor
	{
		#region "Constants"
		const long TicksPerMicrosecond = 10;
		#endregion

		#region "Settings"

		/// <summary>
		/// Setting: Set how many times you want to record the mouse.
		/// </summary>
		public int UpdatesPerSecond
		{
			get;
			set;
		}

		/// <summary>
		/// Setting: Set the maximum amount of seconds to record data for in memory.
		/// </summary>
		public int MaxSecondsToRecord
		{
			get;
			set;
		}
		#endregion

		#region "Variables"
		private bool FLAG_CurrentMouseRecorded = false;
		private bool FLAG_NewMouseData = false;
		private int CurrentMouseX = 0;
		private int CurrentMouseY = 0;
		private List<MouseData> MouseDataCollection;
		private Timer MousePollTimer;

		/// <summary>
		/// Flag [r/o]: Is current mouse being recorded, this is used to check to see if initial data has been recorded.
		/// </summary>
		public bool FMouseRecorded
		{
			get
			{
				return this.FLAG_CurrentMouseRecorded;
			}
		}

		/// <summary>
		/// Flag [r/o]: Is new data available from mouse, this is updated as soon as new data has been received.
		/// </summary>
		public bool FMouseNewData
		{
			get
			{
				bool flagStored = this.FLAG_NewMouseData;
				this.FLAG_NewMouseData = false;
				return flagStored;
			}
		}

		/// <summary>
		/// Variable: Latest Mouse Position X
		/// </summary>
		public int MouseX
		{
			get
			{
				return this.CurrentMouseX;
			}
		}

		/// <summary>
		/// Variable: Latest Mouse Position Y
		/// </summary>
		public int MouseY
		{
			get
			{
				return this.CurrentMouseY;
			}
		}
		#endregion

		public MouseMonitor()
		{
			this.Clear();
		}

		/// <summary>
		/// Gets last data added
		/// </summary>
		public MouseData GetLastData()
		{
			if(MouseDataCollection.Count > 0)
			{
				return this.MouseDataCollection[this.MouseDataCollection.Count - 1];
			}
			else
			{
				return new MouseData();
			}
		}

		/// <summary>
		/// Gets last data added from DateTime
		/// </summary>
		public List<MouseData> GetLatestDataFromDate(DateTime from)
		{
			IEnumerable<MouseData> results = MouseDataCollection.Where(s => s.MouseRecordedTime >= from);
			return results.ToList<MouseData>();
		}

		/// <summary>
		/// Get all recorded data
		/// </summary>
		public List<MouseData> GetFullDataset()
		{
			return this.MouseDataCollection;
		}

		/// <summary>
		/// Get all recorded data between 2 dates
		/// </summary>
		public List<MouseData> GetDataBetweenDates(DateTime start, DateTime end)
		{
			IEnumerable<MouseData> results = MouseDataCollection.Where(s => s.MouseRecordedTime >= start && s.MouseRecordedTime <= end);
			return results.ToList<MouseData>();
		}

		/// <summary>
		/// Start the tracking of the mouse asynchronously
		/// </summary>
		public void StartTracking()
		{
			this.MouseDataCollection = new List<MouseData>();
			this.MousePollTimer = new Timer((1 / (double)this.UpdatesPerSecond) * 1000);
			this.MousePollTimer.Elapsed += new ElapsedEventHandler(TickPoller);
			this.MousePollTimer.Start();
		}

		/// <summary>
		/// Stop the tracking of the mouse and free up resources
		/// </summary>
		public void StopTracking()
		{
			if (this.MousePollTimer != null)
				this.MousePollTimer.Stop();

			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
		}

		/// <summary>
		/// Clear all stored data and reset flags to default
		/// </summary>
		public void Clear()
		{
			this.FLAG_CurrentMouseRecorded = false;
			this.FLAG_NewMouseData = false;
			this.CurrentMouseX = 0;
			this.CurrentMouseY = 0;
			this.UpdatesPerSecond = 100;
			this.MaxSecondsToRecord = 60;

			if(this.MouseDataCollection != null)
			{
				this.MouseDataCollection.Clear();
				this.MouseDataCollection = null;
			}

			if(this.MousePollTimer != null)
			{
				this.MousePollTimer.Stop();
				this.MousePollTimer = null;
			}
		}

		/// <summary>
		/// Update the mouse position with new data
		/// </summary>
		private MouseData PollUpdate()
		{
			MouseInput.POINT currentMouseData = MouseInput.GetCursorPosition();
			MouseData newMouseData = new MouseData();
			newMouseData.MouseX = currentMouseData.X;
			newMouseData.MouseY = currentMouseData.Y;
			newMouseData.MouseRecordedTime = DateTime.Now;
			newMouseData.MouseButtonPressed = MouseInput.GetMouseButtonState();
			return newMouseData;
		}

		/// <summary>
		/// Update the new data and push the new data to a collection
		/// </summary>
		private void PushNewData(MouseData newData)
		{
			this.CurrentMouseX = newData.MouseX;
			this.CurrentMouseY = newData.MouseY;

			this.MouseDataCollection.Add(newData);
			if (!this.FLAG_CurrentMouseRecorded)
				this.FLAG_CurrentMouseRecorded = true;

			if (!this.FLAG_NewMouseData)
				this.FLAG_NewMouseData = true;

			this.ClearOldData();
		}

		/// <summary>
		/// Clear any old data mouse data from collection
		/// </summary>
		private void ClearOldData()
		{
			for(int i = 0; i < this.MouseDataCollection.Count; i++)
			{
				//PROBLEM: The list MUST be ordered in first item added being first in list, if list is not ordered by date this will not give the correct answer.
				//TODO: NEED TO FIX
				if (this.MouseDataCollection[i].MouseRecordedTime > DateTime.Now.AddSeconds(-this.MaxSecondsToRecord))
					break;
				else
					this.MouseDataCollection.RemoveAt(i);

			}
		}

		#region "Timer Methods"
		public void TickPoller(object sender, ElapsedEventArgs e)
		{
			MouseData updatedPos = this.PollUpdate();
			this.PushNewData(updatedPos);
		}
		#endregion
	}
}
