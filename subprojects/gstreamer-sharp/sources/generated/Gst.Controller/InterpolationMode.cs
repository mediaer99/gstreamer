// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Controller {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.Controller.InterpolationModeGType))]
	public enum InterpolationMode {

		None = 0,
		Linear = 1,
		Cubic = 2,
		CubicMonotonic = 3,
	}

	internal class InterpolationModeGType {
		[DllImport ("gstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_interpolation_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_interpolation_mode_get_type ());
			}
		}
	}
#endregion
}
