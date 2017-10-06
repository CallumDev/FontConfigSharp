using System;
namespace FontConfigSharp
{
	public class FcCharSet : IDisposable
	{
		internal IntPtr Handle;

		public FcCharSet()
		{
			Handle = Native.FcCharSetCreate();
		}

		public void AddCharacter(uint codepoint)
		{
			Native.FcCharSetAddChar(Handle, codepoint);
		}

		public void Dispose()
		{
			Native.FcCharSetDestroy(Handle);
		}
	}
}
