using System;
using FontConfigSharp;
namespace ListFontExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var config = Fc.InitLoadConfigAndFonts ();

			var pat = new FcPattern ();

			var os = new FcObjectSet ();
			os.Add (Fc.FC_FAMILY);
			os.Add (Fc.FC_STYLE);
			os.Add (Fc.FC_LANG);
			os.Add (Fc.FC_FILE);
			os.Add (String.Empty);

			var fs = FcFontSet.FromList (config, pat, os);
			for (int i = 0; i < fs.Count; i++) {
				var font = fs [i];
				string file = "", family = "", style = "";
				if (font.GetString (Fc.FC_FILE, 0, ref file) == FcResult.Match &&
				   font.GetString (Fc.FC_FAMILY, 0, ref family) == FcResult.Match &&
				   font.GetString (Fc.FC_STYLE, 0, ref style) == FcResult.Match) {
					if (file.EndsWith (".ttf") || file.EndsWith (".otf")) {
						Console.WriteLine ("{0}, {1}: {2}", family, style, file);
					}
				}
			}
			os.Dispose ();
			pat.Dispose ();
			fs.Dispose ();
		}
	}
}
