using System;

namespace FontConfigSharp
{
	public static class Fc
	{
		public const string FC_FAMILY = "family";
		public const string FC_STYLE = "style";
		public const string FC_LANG = "lang";
		public const string FC_FILE = "file";

		public static FcConfig InitLoadConfigAndFonts()
		{
			return new FcConfig (Native.FcInitLoadConfigAndFonts ());
		}
	}
}

