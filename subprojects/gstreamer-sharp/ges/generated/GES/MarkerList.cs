// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MarkerList : GLib.Object {

		public MarkerList (IntPtr raw) : base(raw) {}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_marker_list_new();

		public MarkerList () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MarkerList)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = ges_marker_list_new();
		}

		[GLib.Property ("flags")]
		public GES.MarkerFlags Flags {
			get {
				GLib.Value val = GetProperty ("flags");
				GES.MarkerFlags ret = (GES.MarkerFlags) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("flags", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("marker-added")]
		public event GES.MarkerAddedHandler MarkerAdded {
			add {
				this.AddSignalHandler ("marker-added", value, typeof (GES.MarkerAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("marker-added", value);
			}
		}

		[GLib.Signal("marker-moved")]
		public event GES.MarkerMovedHandler MarkerMoved {
			add {
				this.AddSignalHandler ("marker-moved", value, typeof (GES.MarkerMovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("marker-moved", value);
			}
		}

		[GLib.Signal("marker-removed")]
		public event GES.MarkerRemovedHandler MarkerRemoved {
			add {
				this.AddSignalHandler ("marker-removed", value, typeof (GES.MarkerRemovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("marker-removed", value);
			}
		}

		static MarkerAddedNativeDelegate MarkerAdded_cb_delegate;
		static MarkerAddedNativeDelegate MarkerAddedVMCallback {
			get {
				if (MarkerAdded_cb_delegate == null)
					MarkerAdded_cb_delegate = new MarkerAddedNativeDelegate (MarkerAdded_cb);
				return MarkerAdded_cb_delegate;
			}
		}

		static void OverrideMarkerAdded (GLib.GType gtype)
		{
			OverrideMarkerAdded (gtype, MarkerAddedVMCallback);
		}

		static void OverrideMarkerAdded (GLib.GType gtype, MarkerAddedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "marker-added", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MarkerAddedNativeDelegate (IntPtr inst, ulong position, IntPtr marker);

		static void MarkerAdded_cb (IntPtr inst, ulong position, IntPtr marker)
		{
			try {
				MarkerList __obj = GLib.Object.GetObject (inst, false) as MarkerList;
				__obj.OnMarkerAdded (position, GLib.Object.GetObject(marker) as GES.Marker);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.MarkerList), ConnectionMethod="OverrideMarkerAdded")]
		protected virtual void OnMarkerAdded (ulong position, GES.Marker marker)
		{
			InternalMarkerAdded (position, marker);
		}

		private void InternalMarkerAdded (ulong position, GES.Marker marker)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (position);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (marker);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static MarkerMovedNativeDelegate MarkerMoved_cb_delegate;
		static MarkerMovedNativeDelegate MarkerMovedVMCallback {
			get {
				if (MarkerMoved_cb_delegate == null)
					MarkerMoved_cb_delegate = new MarkerMovedNativeDelegate (MarkerMoved_cb);
				return MarkerMoved_cb_delegate;
			}
		}

		static void OverrideMarkerMoved (GLib.GType gtype)
		{
			OverrideMarkerMoved (gtype, MarkerMovedVMCallback);
		}

		static void OverrideMarkerMoved (GLib.GType gtype, MarkerMovedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "marker-moved", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MarkerMovedNativeDelegate (IntPtr inst, ulong previous_position, ulong new_position, IntPtr marker);

		static void MarkerMoved_cb (IntPtr inst, ulong previous_position, ulong new_position, IntPtr marker)
		{
			try {
				MarkerList __obj = GLib.Object.GetObject (inst, false) as MarkerList;
				__obj.OnMarkerMoved (previous_position, new_position, GLib.Object.GetObject(marker) as GES.Marker);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.MarkerList), ConnectionMethod="OverrideMarkerMoved")]
		protected virtual void OnMarkerMoved (ulong previous_position, ulong new_position, GES.Marker marker)
		{
			InternalMarkerMoved (previous_position, new_position, marker);
		}

		private void InternalMarkerMoved (ulong previous_position, ulong new_position, GES.Marker marker)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (4);
			GLib.Value[] vals = new GLib.Value [4];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (previous_position);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (new_position);
			inst_and_params.Append (vals [2]);
			vals [3] = new GLib.Value (marker);
			inst_and_params.Append (vals [3]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static MarkerRemovedNativeDelegate MarkerRemoved_cb_delegate;
		static MarkerRemovedNativeDelegate MarkerRemovedVMCallback {
			get {
				if (MarkerRemoved_cb_delegate == null)
					MarkerRemoved_cb_delegate = new MarkerRemovedNativeDelegate (MarkerRemoved_cb);
				return MarkerRemoved_cb_delegate;
			}
		}

		static void OverrideMarkerRemoved (GLib.GType gtype)
		{
			OverrideMarkerRemoved (gtype, MarkerRemovedVMCallback);
		}

		static void OverrideMarkerRemoved (GLib.GType gtype, MarkerRemovedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "marker-removed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MarkerRemovedNativeDelegate (IntPtr inst, IntPtr marker);

		static void MarkerRemoved_cb (IntPtr inst, IntPtr marker)
		{
			try {
				MarkerList __obj = GLib.Object.GetObject (inst, false) as MarkerList;
				__obj.OnMarkerRemoved (GLib.Object.GetObject(marker) as GES.Marker);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.MarkerList), ConnectionMethod="OverrideMarkerRemoved")]
		protected virtual void OnMarkerRemoved (GES.Marker marker)
		{
			InternalMarkerRemoved (marker);
		}

		private void InternalMarkerRemoved (GES.Marker marker)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (marker);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_marker_list_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_marker_list_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_marker_list_add(IntPtr raw, ulong position);

		public GES.Marker Add(ulong position) {
			IntPtr raw_ret = ges_marker_list_add(Handle, position);
			GES.Marker ret = GLib.Object.GetObject(raw_ret) as GES.Marker;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_marker_list_get_markers(IntPtr raw);

		public GES.Marker[] Markers { 
			get {
				IntPtr raw_ret = ges_marker_list_get_markers(Handle);
				GES.Marker[] ret = (GES.Marker[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GES.Marker));
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_marker_list_move(IntPtr raw, IntPtr marker, ulong position);

		public bool Move(GES.Marker marker, ulong position) {
			bool raw_ret = ges_marker_list_move(Handle, marker == null ? IntPtr.Zero : marker.Handle, position);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_marker_list_remove(IntPtr raw, IntPtr marker);

		public bool Remove(GES.Marker marker) {
			bool raw_ret = ges_marker_list_remove(Handle, marker == null ? IntPtr.Zero : marker.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern uint ges_marker_list_size(IntPtr raw);

		public uint Size() {
			uint raw_ret = ges_marker_list_size(Handle);
			uint ret = raw_ret;
			return ret;
		}


		static MarkerList ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
