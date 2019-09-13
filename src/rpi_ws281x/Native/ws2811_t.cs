﻿using System;
using System.Runtime.InteropServices;

namespace Native
{
	[SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
	[StructLayout(LayoutKind.Sequential)]
	internal struct ws2811_t
	{
		public long render_wait_time;
		public IntPtr device;
		public IntPtr rpi_hw;
		public uint freq;
		public int dmanum;
		/* [MarshalAs(UnmanagedType.ByValArray, SizeConst = PInvoke.RPI_PWM_CHANNELS)]
		public ws2811_channel_t[] channel; */
		public ws2811_channel_t channel_1;
		public ws2811_channel_t channel_2;
	}
}
