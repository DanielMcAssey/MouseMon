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
		public int UpdatesPerSecond
		{
			get;
			set;
		}

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

		public bool FMouseRecorded
		{
			get
			{
				return this.FLAG_CurrentMouseRecorded;
			}
		}

		public bool FMouseNewData
		{
			get
			{
				bool flagStored = this.FLAG_NewMouseData;
				this.FLAG_NewMouseData = false;
				return flagStored;
			}
		}

		public int MouseX
		{
			get
			{
				return this.CurrentMouseX;
			}
		}

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
			//Set default vars
			this.UpdatesPerSecond = 100;
			this.MaxSecondsToRecord = 60;
		}

		/// <summary>
		/// Gets last data added
		/// </summary>
		public MouseData GetLatestData()
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
		/// Update the mouse position with new data
		/// </summary>
		private MouseData PollUpdate()
		{
			MouseInput.POINT currentMouseData = MouseInput.GetCursorPosition();
			MouseData newMouseData = new MouseData();
			newMouseData.MouseX = currentMouseData.X;
			newMouseData.MouseY = currentMouseData.Y;
			newMouseData.MouseRecordedTime = DateTime.Now;
			return newMouseData;
		}

		/// <summary>
		/// Update the new data and push the new data to a collection
		/// </summary>
		private void PushNewData(MouseData newData)
		{
			this.CurrentMouseX = new int(); //redeclare the int so memory gets reaassigned, safer
			this.CurrentMouseY = new int();
			this.CurrentMouseX = (int)newData.MouseX; //Recast to same var type - reassign mem, safer
			this.CurrentMouseY = (int)newData.MouseY;

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
				//PROBLEM: The list MUST be ordered in last item added being first in list
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
