// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void LoadSerializedInfoHandler(object o, LoadSerializedInfoArgs args);

	public class LoadSerializedInfoArgs : GLib.SignalArgs {
		public string Uri{
			get {
				return (string) Args [0];
			}
		}

	}
}
