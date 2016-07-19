using System;
using System.Runtime.InteropServices;
namespace FontConfigSharp
{
	[StructLayout(LayoutKind.Sequential)]
	public class FcFontSet : IDisposable
	{
		_FcFontSet fset;
		IntPtr handle;
		struct _FcFontSet
		{
			public int nfont;
			public int sfont;
			public IntPtr fonts;
		}

		internal FcFontSet(IntPtr handle)
		{
			this.handle = handle;
			fset = (_FcFontSet)Marshal.PtrToStructure(handle, typeof(_FcFontSet));
		}

		public FcPattern this[int index]
		{
			get {
				if (index >= fset.nfont)
					throw new IndexOutOfRangeException ();
				return new FcPattern (Marshal.ReadIntPtr (fset.fonts, index * Marshal.SizeOf(typeof(IntPtr))));
			}
		}

		public int Count {
			get {
				return fset.nfont;
			}
		}

		public static FcFontSet FromList(FcConfig config, FcPattern pat, FcObjectSet os)
		{
			return new FcFontSet (Native.FcFontList (config.Handle, pat.Handle, os.Handle));
		}

		public void Dispose()
		{
			Native.FcFontSetDestroy (handle);
		}
	}
}

