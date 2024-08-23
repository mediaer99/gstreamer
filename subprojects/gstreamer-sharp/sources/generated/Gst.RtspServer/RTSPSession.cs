// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.RtspServer {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class RTSPSession : GLib.Object {

		public RTSPSession (IntPtr raw) : base(raw) {}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_session_new(IntPtr sessionid);

		public RTSPSession (string sessionid) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RTSPSession)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("sessionid");
				vals.Add (new GLib.Value (sessionid));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_sessionid = GLib.Marshaller.StringToPtrGStrdup (sessionid);
			Raw = gst_rtsp_session_new(native_sessionid);
			GLib.Marshaller.Free (native_sessionid);
		}

		[GLib.Property ("extra-timeout")]
		public uint ExtraTimeout {
			get {
				GLib.Value val = GetProperty ("extra-timeout");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("extra-timeout", val);
				val.Dispose ();
			}
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_session_get_sessionid(IntPtr raw);

		[GLib.Property ("sessionid")]
		public string Sessionid {
			get  {
				IntPtr raw_ret = gst_rtsp_session_get_sessionid(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_rtsp_session_get_timeout(IntPtr raw);

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_session_set_timeout(IntPtr raw, uint timeout);

		[GLib.Property ("timeout")]
		public uint Timeout {
			get  {
				uint raw_ret = gst_rtsp_session_get_timeout(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gst_rtsp_session_set_timeout(Handle, value);
			}
		}

		[GLib.Property ("timeout-always-visible")]
		public bool TimeoutAlwaysVisible {
			get {
				GLib.Value val = GetProperty ("timeout-always-visible");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("timeout-always-visible", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gst_reserved"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_session_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_rtsp_session_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_session_allow_expire(IntPtr raw);

		public void AllowExpire() {
			gst_rtsp_session_allow_expire(Handle);
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_session_dup_media(IntPtr raw, IntPtr path, out int matched);

		public Gst.RtspServer.RTSPSessionMedia DupMedia(string path, out int matched) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = gst_rtsp_session_dup_media(Handle, native_path, out matched);
			Gst.RtspServer.RTSPSessionMedia ret = GLib.Object.GetObject(raw_ret, true) as Gst.RtspServer.RTSPSessionMedia;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_session_filter(IntPtr raw, Gst.RtspServerSharp.RTSPSessionFilterFuncNative func, IntPtr user_data);

		public Gst.RtspServer.RTSPSessionMedia[] Filter(Gst.RtspServer.RTSPSessionFilterFunc func) {
			Gst.RtspServerSharp.RTSPSessionFilterFuncWrapper func_wrapper = new Gst.RtspServerSharp.RTSPSessionFilterFuncWrapper (func);
			IntPtr raw_ret = gst_rtsp_session_filter(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
			Gst.RtspServer.RTSPSessionMedia[] ret = (Gst.RtspServer.RTSPSessionMedia[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.RtspServer.RTSPSessionMedia));
			return ret;
		}

		public Gst.RtspServer.RTSPSessionMedia[] Filter() {
			return Filter (null);
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_session_get_header(IntPtr raw);

		public string Header { 
			get {
				IntPtr raw_ret = gst_rtsp_session_get_header(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_session_get_media(IntPtr raw, IntPtr path, out int matched);

		public Gst.RtspServer.RTSPSessionMedia GetMedia(string path, out int matched) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = gst_rtsp_session_get_media(Handle, native_path, out matched);
			Gst.RtspServer.RTSPSessionMedia ret = GLib.Object.GetObject(raw_ret) as Gst.RtspServer.RTSPSessionMedia;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_session_is_expired(IntPtr raw, IntPtr now);

		[Obsolete]
		public bool IsExpired(IntPtr now) {
			bool raw_ret = gst_rtsp_session_is_expired(Handle, now);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_session_is_expired_usec(IntPtr raw, long now);

		public bool IsExpiredUsec(long now) {
			bool raw_ret = gst_rtsp_session_is_expired_usec(Handle, now);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_session_manage_media(IntPtr raw, IntPtr path, IntPtr media);

		public Gst.RtspServer.RTSPSessionMedia ManageMedia(string path, Gst.RtspServer.RTSPMedia media) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = gst_rtsp_session_manage_media(Handle, native_path, media == null ? IntPtr.Zero : media.OwnedHandle);
			Gst.RtspServer.RTSPSessionMedia ret = GLib.Object.GetObject(raw_ret) as Gst.RtspServer.RTSPSessionMedia;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_session_next_timeout(IntPtr raw, IntPtr now);

		[Obsolete]
		public int NextTimeout(IntPtr now) {
			int raw_ret = gst_rtsp_session_next_timeout(Handle, now);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_session_next_timeout_usec(IntPtr raw, long now);

		public int NextTimeoutUsec(long now) {
			int raw_ret = gst_rtsp_session_next_timeout_usec(Handle, now);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_session_prevent_expire(IntPtr raw);

		public void PreventExpire() {
			gst_rtsp_session_prevent_expire(Handle);
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_session_release_media(IntPtr raw, IntPtr media);

		public bool ReleaseMedia(Gst.RtspServer.RTSPSessionMedia media) {
			bool raw_ret = gst_rtsp_session_release_media(Handle, media == null ? IntPtr.Zero : media.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_session_touch(IntPtr raw);

		public void Touch() {
			gst_rtsp_session_touch(Handle);
		}


		static RTSPSession ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
