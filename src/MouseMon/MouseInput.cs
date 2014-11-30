using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MouseMon
{
	static class MouseInput
	{
		/// <summary>
		/// Struct representing a point.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct POINT
		{
			public int X;
			public int Y;

			public POINT(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}

			public POINT(System.Drawing.Point pt) : this(pt.X, pt.Y) { }

			public static implicit operator System.Drawing.Point(POINT p)
			{
				return new System.Drawing.Point(p.X, p.Y);
			}

			public static implicit operator POINT(System.Drawing.Point p)
			{
				return new POINT(p.X, p.Y);
			}
		}

		/// <summary>
		/// Retrieves the cursor's position, in screen coordinates.
		/// </summary>
		/// <see>See MSDN documentation for further information.</see>
		[DllImport("user32.dll")]
		public static extern bool GetCursorPos(out POINT lpPoint);

		public static POINT GetCursorPosition()
		{
			POINT lpPoint;
			GetCursorPos(out lpPoint);

			return lpPoint;
		}
	}
}
