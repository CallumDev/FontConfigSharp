using System;

namespace FontConfigSharp
{
	public enum FcResult : int {
		Match,
		NoMatch,
		TypeMismatch,
		NoId,
		OutOfMemory
	}
}

