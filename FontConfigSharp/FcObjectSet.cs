using System;

namespace FontConfigSharp
{
	public class FcObjectSet : IDisposable
	{
		internal IntPtr Handle;

		public FcObjectSet()
		{
			Handle = Native.FcObjectSetCreate ();
		}

		internal FcObjectSet (IntPtr handle)
		{
			Handle = handle;
		}

		public void Add(string obj)
		{
			Native.FcObjectSetAdd (Handle, obj);
		}

		public void Dispose()
		{
			Native.FcObjectSetDestroy (Handle);
		}
	}
}

