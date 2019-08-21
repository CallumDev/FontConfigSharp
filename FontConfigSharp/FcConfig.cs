using System;

namespace FontConfigSharp
{
	public class FcConfig
	{
		internal IntPtr Handle;
		internal FcConfig(IntPtr handle)
		{
			Handle = handle;
		}
        public void SetCurrent()
        {
            Native.FcConfigSetCurrent(Handle);
        }
    }
}

