﻿using System;
using System.Runtime.InteropServices;
namespace FontConfigSharp
{
	internal static class Native
	{
		[DllImport("libfontconfig.so")]
		public static extern IntPtr FcInitLoadConfigAndFonts();
		[DllImport("libfontconfig.so")]
		public static extern IntPtr FcPatternCreate();
		[DllImport("libfontconfig.so")]
		public static extern IntPtr FcFontList (IntPtr config, IntPtr p, IntPtr os);
		//this is varargs
		[DllImport("libfontconfig.so")]
		public static extern IntPtr FcObjectSetCreate();
		[DllImport("libfontconfig.so")]
		public static extern void FcFontSetDestroy (IntPtr fs);
		[DllImport("libfontconfig.so")]
		public static extern int FcObjectSetAdd (IntPtr os, [MarshalAs(UnmanagedType.LPStr)]string obj);
		[DllImport("libfontconfig.so")]
		public static extern FcResult FcPatternGetString (
			IntPtr p,
			[MarshalAs (UnmanagedType.LPStr)]string obj,
			int n,
			ref IntPtr s);
		[DllImport("libfontconfig.so")]
		public static extern void FcPatternDestroy (IntPtr p);
		[DllImport("libfontconfig.so")]
		public static extern void FcObjectSetDestroy (IntPtr os);

	}
}
