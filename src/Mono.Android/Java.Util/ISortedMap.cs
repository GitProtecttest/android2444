using System;
using Android.Runtime;

namespace Java.Util;

#if ANDROID_35
public partial interface ISortedMap
{
	private static Delegate? cb_reversed;

#pragma warning disable 0169
	[global::System.Runtime.Versioning.SupportedOSPlatformAttribute ("android35.0")]
	private static Delegate GetReversedHandler ()
	{
		return cb_reversed ??= new _JniMarshal_PP_L (n_Reversed);
	}

	[global::System.Diagnostics.DebuggerDisableUserUnhandledExceptions]
	[global::System.Runtime.Versioning.SupportedOSPlatformAttribute ("android35.0")]
	private static IntPtr n_Reversed (IntPtr jnienv, IntPtr native__this)
	{
		if (!global::Java.Interop.JniEnvironment.BeginMarshalMethod (jnienv, out var __envp, out var __r))
			return default;

		try {
			var __this = global::Java.Lang.Object.GetObject<Java.Util.ISortedMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Reversed ());
		} catch (global::System.Exception __e) {
			__r.OnUserUnhandledException (ref __envp, __e);
			return default;
		} finally {
			global::Java.Interop.JniEnvironment.EndMarshalMethod (ref __envp);
		}
	}
#pragma warning restore 0169

	// This gets generated as:
	// return Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
	// instead of:
	// return global::Java.Lang.Object.GetObject<Java.Util.ISequencedMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;

	// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='SortedMap']/method[@name='reversed' and count(parameter)=0]"
	[global::System.Runtime.Versioning.SupportedOSPlatformAttribute ("android35.0")]
	[Register ("reversed", "()Ljava/util/SortedMap;", "GetReversedHandler:Java.Util.ISortedMap, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 35)]
	unsafe Java.Util.ISequencedMap Java.Util.ISequencedMap.Reversed ()
	{
		const string __id = "reversed.()Ljava/util/SortedMap;";
		try {
			var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
			return global::Java.Lang.Object.GetObject<Java.Util.ISequencedMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
		} finally {
		}
	}
}
#endif
