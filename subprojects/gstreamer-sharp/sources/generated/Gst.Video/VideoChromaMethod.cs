// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.Video.VideoChromaMethodGType))]
	public enum VideoChromaMethod {

		Nearest = 0,
		Linear = 1,
	}

	internal class VideoChromaMethodGType {
		[DllImport ("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_chroma_method_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_chroma_method_get_type ());
			}
		}
	}
#endregion
}
