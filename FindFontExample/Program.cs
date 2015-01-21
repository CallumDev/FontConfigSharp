using System;
using FontConfigSharp;
namespace FindFontExample
{
	class MainClass
	{
		//Gets the path to a font
		public static void Main (string[] args)
		{
			var config = Fc.InitLoadConfigAndFonts ();
			var pat = FcPattern.FromFamilyName ("sans");
			pat.ConfigSubstitute (config, FcMatchKind.Pattern);
			pat.DefaultSubstitute ();
			FcResult result;
			var font = pat.Match (config, out result);
			string file = null;
			if (font.GetString (Fc.FC_FILE, 0, ref file) == FcResult.Match) {
				Console.WriteLine (file);
			}
			pat.Dispose ();
		}
	}
}
