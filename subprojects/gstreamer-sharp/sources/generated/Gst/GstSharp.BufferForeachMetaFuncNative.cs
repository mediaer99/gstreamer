// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool BufferForeachMetaFuncNative(IntPtr buffer, IntPtr meta, IntPtr user_data);

	internal class BufferForeachMetaFuncInvoker {

		BufferForeachMetaFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~BufferForeachMetaFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal BufferForeachMetaFuncInvoker (BufferForeachMetaFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal BufferForeachMetaFuncInvoker (BufferForeachMetaFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal BufferForeachMetaFuncInvoker (BufferForeachMetaFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.BufferForeachMetaFunc Handler {
			get {
				return new Gst.BufferForeachMetaFunc(InvokeNative);
			}
		}

		bool InvokeNative (Gst.Buffer buffer, out Gst.Meta meta)
		{
			IntPtr native_meta = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Meta)));
			bool __result = native_cb (buffer == null ? IntPtr.Zero : buffer.Handle, native_meta, __data);
			meta = Gst.Meta.New (native_meta);
			Marshal.FreeHGlobal (native_meta);
			return __result;
		}
	}

	internal class BufferForeachMetaFuncWrapper {

		public bool NativeCallback (IntPtr buffer, IntPtr meta, IntPtr user_data)
		{
			try {
				Gst.Meta mymeta;

				bool __ret = managed (buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (buffer, typeof (Gst.Buffer), false), out mymeta);
				if (meta != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (mymeta, meta, false);

				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal BufferForeachMetaFuncNative NativeDelegate;
		Gst.BufferForeachMetaFunc managed;

		public BufferForeachMetaFuncWrapper (Gst.BufferForeachMetaFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new BufferForeachMetaFuncNative (NativeCallback);
		}

		public static Gst.BufferForeachMetaFunc GetManagedDelegate (BufferForeachMetaFuncNative native)
		{
			if (native == null)
				return null;
			BufferForeachMetaFuncWrapper wrapper = (BufferForeachMetaFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
