using System;
using System.Runtime.InteropServices;
namespace FontConfigSharp
{
	public class FcPattern : IDisposable
	{
		internal IntPtr Handle;

		public FcPattern()
		{
			Handle = Native.FcPatternCreate ();
		}

		internal FcPattern(IntPtr handle)
		{
			Handle = handle;
		}

		public FcResult GetString(string obj, int n, ref string val)
		{
			var ptr = IntPtr.Zero;
			var result =  Native.FcPatternGetString (Handle, obj, n, ref ptr);
			if (result == FcResult.Match)
				val = Marshal.PtrToStringAnsi (ptr);
			return result;
		}

		public void Dispose()
		{
			Native.FcPatternDestroy (Handle);
		}
	}
}

