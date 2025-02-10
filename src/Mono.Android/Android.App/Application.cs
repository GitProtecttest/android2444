using System;
using System.Threading;

using Android.Content;
using Android.Runtime;

namespace Android.App {

	partial class Application {

		static Context? _context;
		public static Context Context {
			get {
				if (_context != null)
					return _context;

				var lref = ContextHandle;
				if (lref == IntPtr.Zero)
					throw new InvalidOperationException ("Application.ContextHandle is not set!");
					
				return _context = Java.Lang.Object.GetObject<Context> (lref, JniHandleOwnership.TransferLocalRef)!;
			}
			internal set => _context = value;
		}

		internal static IntPtr ContextHandle { get; set; }

		static SyncContext? _sync;
		public static SynchronizationContext SynchronizationContext {
			get {
				if (_sync == null)
					_sync = new SyncContext ();
				return _sync;
			}
		}
	}
}

