// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class WebRTCDataChannel : GLib.Object {

		protected WebRTCDataChannel (IntPtr raw) : base(raw) {}

		protected WebRTCDataChannel() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("buffered-amount")]
		public ulong BufferedAmount {
			get {
				GLib.Value val = GetProperty ("buffered-amount");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("buffered-amount-low-threshold")]
		public ulong BufferedAmountLowThreshold {
			get {
				GLib.Value val = GetProperty ("buffered-amount-low-threshold");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("buffered-amount-low-threshold", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("id")]
		public int Id {
			get {
				GLib.Value val = GetProperty ("id");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("label")]
		public string Label {
			get {
				GLib.Value val = GetProperty ("label");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("max-packet-lifetime")]
		public int MaxPacketLifetime {
			get {
				GLib.Value val = GetProperty ("max-packet-lifetime");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("max-retransmits")]
		public int MaxRetransmits {
			get {
				GLib.Value val = GetProperty ("max-retransmits");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("negotiated")]
		public bool Negotiated {
			get {
				GLib.Value val = GetProperty ("negotiated");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("ordered")]
		public bool Ordered {
			get {
				GLib.Value val = GetProperty ("ordered");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("priority")]
		public Gst.WebRTC.WebRTCPriorityType Priority {
			get {
				GLib.Value val = GetProperty ("priority");
				Gst.WebRTC.WebRTCPriorityType ret = (Gst.WebRTC.WebRTCPriorityType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("protocol")]
		public string Protocol {
			get {
				GLib.Value val = GetProperty ("protocol");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("ready-state")]
		public Gst.WebRTC.WebRTCDataChannelState ReadyState {
			get {
				GLib.Value val = GetProperty ("ready-state");
				Gst.WebRTC.WebRTCDataChannelState ret = (Gst.WebRTC.WebRTCDataChannelState) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("on-error")]
		public event Gst.WebRTC.OnErrorHandler OnError {
			add {
				this.AddSignalHandler ("on-error", value, typeof (Gst.WebRTC.OnErrorArgs));
			}
			remove {
				this.RemoveSignalHandler ("on-error", value);
			}
		}

		[GLib.Signal("send-string")]
		public event Gst.WebRTC.SendStringEventHandler SendStringEvent {
			add {
				this.AddSignalHandler ("send-string", value, typeof (Gst.WebRTC.SendStringEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("send-string", value);
			}
		}

		[GLib.Signal("send-data")]
		public event Gst.WebRTC.SendDataEventHandler SendDataEvent {
			add {
				this.AddSignalHandler ("send-data", value, typeof (Gst.WebRTC.SendDataEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("send-data", value);
			}
		}

		[GLib.Signal("close")]
		public event System.EventHandler CloseEvent {
			add {
				this.AddSignalHandler ("close", value);
			}
			remove {
				this.RemoveSignalHandler ("close", value);
			}
		}

		[GLib.Signal("on-message-data")]
		public event Gst.WebRTC.OnMessageDataHandler OnMessageData {
			add {
				this.AddSignalHandler ("on-message-data", value, typeof (Gst.WebRTC.OnMessageDataArgs));
			}
			remove {
				this.RemoveSignalHandler ("on-message-data", value);
			}
		}

		[GLib.Signal("on-buffered-amount-low")]
		public event System.EventHandler OnBufferedAmountLow {
			add {
				this.AddSignalHandler ("on-buffered-amount-low", value);
			}
			remove {
				this.RemoveSignalHandler ("on-buffered-amount-low", value);
			}
		}

		[GLib.Signal("on-open")]
		public event System.EventHandler OnOpen {
			add {
				this.AddSignalHandler ("on-open", value);
			}
			remove {
				this.RemoveSignalHandler ("on-open", value);
			}
		}

		[GLib.Signal("on-message-string")]
		public event Gst.WebRTC.OnMessageStringHandler OnMessageString {
			add {
				this.AddSignalHandler ("on-message-string", value, typeof (Gst.WebRTC.OnMessageStringArgs));
			}
			remove {
				this.RemoveSignalHandler ("on-message-string", value);
			}
		}

		static CloseEventNativeDelegate CloseEvent_cb_delegate;
		static CloseEventNativeDelegate CloseEventVMCallback {
			get {
				if (CloseEvent_cb_delegate == null)
					CloseEvent_cb_delegate = new CloseEventNativeDelegate (CloseEvent_cb);
				return CloseEvent_cb_delegate;
			}
		}

		static void OverrideCloseEvent (GLib.GType gtype)
		{
			OverrideCloseEvent (gtype, CloseEventVMCallback);
		}

		static void OverrideCloseEvent (GLib.GType gtype, CloseEventNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "close", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CloseEventNativeDelegate (IntPtr inst);

		static void CloseEvent_cb (IntPtr inst)
		{
			try {
				WebRTCDataChannel __obj = GLib.Object.GetObject (inst, false) as WebRTCDataChannel;
				__obj.OnCloseEvent ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCDataChannel), ConnectionMethod="OverrideCloseEvent")]
		protected virtual void OnCloseEvent ()
		{
			InternalCloseEvent ();
		}

		private void InternalCloseEvent ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static OnBufferedAmountLowNativeDelegate OnBufferedAmountLow_cb_delegate;
		static OnBufferedAmountLowNativeDelegate OnBufferedAmountLowVMCallback {
			get {
				if (OnBufferedAmountLow_cb_delegate == null)
					OnBufferedAmountLow_cb_delegate = new OnBufferedAmountLowNativeDelegate (OnBufferedAmountLow_cb);
				return OnBufferedAmountLow_cb_delegate;
			}
		}

		static void OverrideOnBufferedAmountLow (GLib.GType gtype)
		{
			OverrideOnBufferedAmountLow (gtype, OnBufferedAmountLowVMCallback);
		}

		static void OverrideOnBufferedAmountLow (GLib.GType gtype, OnBufferedAmountLowNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "on-buffered-amount-low", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OnBufferedAmountLowNativeDelegate (IntPtr inst);

		static void OnBufferedAmountLow_cb (IntPtr inst)
		{
			try {
				WebRTCDataChannel __obj = GLib.Object.GetObject (inst, false) as WebRTCDataChannel;
				__obj.OnOnBufferedAmountLow ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCDataChannel), ConnectionMethod="OverrideOnBufferedAmountLow")]
		protected virtual void OnOnBufferedAmountLow ()
		{
			InternalOnBufferedAmountLow ();
		}

		private void InternalOnBufferedAmountLow ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static OnErrorNativeDelegate OnError_cb_delegate;
		static OnErrorNativeDelegate OnErrorVMCallback {
			get {
				if (OnError_cb_delegate == null)
					OnError_cb_delegate = new OnErrorNativeDelegate (OnError_cb);
				return OnError_cb_delegate;
			}
		}

		static void OverrideOnError (GLib.GType gtype)
		{
			OverrideOnError (gtype, OnErrorVMCallback);
		}

		static void OverrideOnError (GLib.GType gtype, OnErrorNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "on-error", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OnErrorNativeDelegate (IntPtr inst, IntPtr error);

		static void OnError_cb (IntPtr inst, IntPtr error)
		{
			try {
				WebRTCDataChannel __obj = GLib.Object.GetObject (inst, false) as WebRTCDataChannel;
				__obj.OnOnError (error);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCDataChannel), ConnectionMethod="OverrideOnError")]
		protected virtual void OnOnError (IntPtr error)
		{
			InternalOnError (error);
		}

		private void InternalOnError (IntPtr error)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (error);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static OnMessageDataNativeDelegate OnMessageData_cb_delegate;
		static OnMessageDataNativeDelegate OnMessageDataVMCallback {
			get {
				if (OnMessageData_cb_delegate == null)
					OnMessageData_cb_delegate = new OnMessageDataNativeDelegate (OnMessageData_cb);
				return OnMessageData_cb_delegate;
			}
		}

		static void OverrideOnMessageData (GLib.GType gtype)
		{
			OverrideOnMessageData (gtype, OnMessageDataVMCallback);
		}

		static void OverrideOnMessageData (GLib.GType gtype, OnMessageDataNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "on-message-data", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OnMessageDataNativeDelegate (IntPtr inst, IntPtr data);

		static void OnMessageData_cb (IntPtr inst, IntPtr data)
		{
			try {
				WebRTCDataChannel __obj = GLib.Object.GetObject (inst, false) as WebRTCDataChannel;
				__obj.OnOnMessageData (new GLib.Bytes(data));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCDataChannel), ConnectionMethod="OverrideOnMessageData")]
		protected virtual void OnOnMessageData (GLib.Bytes data)
		{
			InternalOnMessageData (data);
		}

		private void InternalOnMessageData (GLib.Bytes data)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (data);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static OnMessageStringNativeDelegate OnMessageString_cb_delegate;
		static OnMessageStringNativeDelegate OnMessageStringVMCallback {
			get {
				if (OnMessageString_cb_delegate == null)
					OnMessageString_cb_delegate = new OnMessageStringNativeDelegate (OnMessageString_cb);
				return OnMessageString_cb_delegate;
			}
		}

		static void OverrideOnMessageString (GLib.GType gtype)
		{
			OverrideOnMessageString (gtype, OnMessageStringVMCallback);
		}

		static void OverrideOnMessageString (GLib.GType gtype, OnMessageStringNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "on-message-string", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OnMessageStringNativeDelegate (IntPtr inst, IntPtr data);

		static void OnMessageString_cb (IntPtr inst, IntPtr data)
		{
			try {
				WebRTCDataChannel __obj = GLib.Object.GetObject (inst, false) as WebRTCDataChannel;
				__obj.OnOnMessageString (GLib.Marshaller.Utf8PtrToString (data));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCDataChannel), ConnectionMethod="OverrideOnMessageString")]
		protected virtual void OnOnMessageString (string data)
		{
			InternalOnMessageString (data);
		}

		private void InternalOnMessageString (string data)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (data);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static OnOpenNativeDelegate OnOpen_cb_delegate;
		static OnOpenNativeDelegate OnOpenVMCallback {
			get {
				if (OnOpen_cb_delegate == null)
					OnOpen_cb_delegate = new OnOpenNativeDelegate (OnOpen_cb);
				return OnOpen_cb_delegate;
			}
		}

		static void OverrideOnOpen (GLib.GType gtype)
		{
			OverrideOnOpen (gtype, OnOpenVMCallback);
		}

		static void OverrideOnOpen (GLib.GType gtype, OnOpenNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "on-open", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OnOpenNativeDelegate (IntPtr inst);

		static void OnOpen_cb (IntPtr inst)
		{
			try {
				WebRTCDataChannel __obj = GLib.Object.GetObject (inst, false) as WebRTCDataChannel;
				__obj.OnOnOpen ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCDataChannel), ConnectionMethod="OverrideOnOpen")]
		protected virtual void OnOnOpen ()
		{
			InternalOnOpen ();
		}

		private void InternalOnOpen ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static SendDataEventNativeDelegate SendDataEvent_cb_delegate;
		static SendDataEventNativeDelegate SendDataEventVMCallback {
			get {
				if (SendDataEvent_cb_delegate == null)
					SendDataEvent_cb_delegate = new SendDataEventNativeDelegate (SendDataEvent_cb);
				return SendDataEvent_cb_delegate;
			}
		}

		static void OverrideSendDataEvent (GLib.GType gtype)
		{
			OverrideSendDataEvent (gtype, SendDataEventVMCallback);
		}

		static void OverrideSendDataEvent (GLib.GType gtype, SendDataEventNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "send-data", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SendDataEventNativeDelegate (IntPtr inst, IntPtr data);

		static void SendDataEvent_cb (IntPtr inst, IntPtr data)
		{
			try {
				WebRTCDataChannel __obj = GLib.Object.GetObject (inst, false) as WebRTCDataChannel;
				__obj.OnSendDataEvent (new GLib.Bytes(data));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCDataChannel), ConnectionMethod="OverrideSendDataEvent")]
		protected virtual void OnSendDataEvent (GLib.Bytes data)
		{
			InternalSendDataEvent (data);
		}

		private void InternalSendDataEvent (GLib.Bytes data)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (data);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static SendStringEventNativeDelegate SendStringEvent_cb_delegate;
		static SendStringEventNativeDelegate SendStringEventVMCallback {
			get {
				if (SendStringEvent_cb_delegate == null)
					SendStringEvent_cb_delegate = new SendStringEventNativeDelegate (SendStringEvent_cb);
				return SendStringEvent_cb_delegate;
			}
		}

		static void OverrideSendStringEvent (GLib.GType gtype)
		{
			OverrideSendStringEvent (gtype, SendStringEventVMCallback);
		}

		static void OverrideSendStringEvent (GLib.GType gtype, SendStringEventNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "send-string", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SendStringEventNativeDelegate (IntPtr inst, IntPtr data);

		static void SendStringEvent_cb (IntPtr inst, IntPtr data)
		{
			try {
				WebRTCDataChannel __obj = GLib.Object.GetObject (inst, false) as WebRTCDataChannel;
				__obj.OnSendStringEvent (GLib.Marshaller.Utf8PtrToString (data));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCDataChannel), ConnectionMethod="OverrideSendStringEvent")]
		protected virtual void OnSendStringEvent (string data)
		{
			InternalSendStringEvent (data);
		}

		private void InternalSendStringEvent (string data)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (data);
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

		[DllImport("gstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_data_channel_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_webrtc_data_channel_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_webrtc_data_channel_close(IntPtr raw);

		public void Close() {
			gst_webrtc_data_channel_close(Handle);
		}

		[DllImport("gstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_webrtc_data_channel_send_data(IntPtr raw, IntPtr data);

		public void SendData(GLib.Bytes data) {
			gst_webrtc_data_channel_send_data(Handle, data == null ? IntPtr.Zero : data.Handle);
		}

		public void SendData() {
			SendData (null);
		}

		[DllImport("gstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_webrtc_data_channel_send_data_full(IntPtr raw, IntPtr data, out IntPtr error);

		public unsafe bool SendDataFull(GLib.Bytes data) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_webrtc_data_channel_send_data_full(Handle, data == null ? IntPtr.Zero : data.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public bool SendDataFull() {
			return SendDataFull (null);
		}

		[DllImport("gstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_webrtc_data_channel_send_string(IntPtr raw, IntPtr str);

		public void SendString(string str) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			gst_webrtc_data_channel_send_string(Handle, native_str);
			GLib.Marshaller.Free (native_str);
		}

		public void SendString() {
			SendString (null);
		}

		[DllImport("gstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_webrtc_data_channel_send_string_full(IntPtr raw, IntPtr str, out IntPtr error);

		public unsafe bool SendStringFull(string str) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_webrtc_data_channel_send_string_full(Handle, native_str, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_str);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public bool SendStringFull() {
			return SendStringFull (null);
		}


		static WebRTCDataChannel ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
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
