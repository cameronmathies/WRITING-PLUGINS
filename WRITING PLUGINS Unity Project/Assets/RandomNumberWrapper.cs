using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class RandomNumberWrapper {

#if UNITY_STANDALONE_WIN
	const string dll = "RanomNumberDLL";
	#elif UNITY_STANDALONE_OSX
	const string dll = "RanomNumberBUNDLE";
#elif Unity_IOS
	const string dll = "__Internal";
#else
	const string dll = "";
#endif

	[DllImport(dll)]
	private static extern int GetRandom();

	public static int GetRandNum(){

	
		#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || Unity_IOS)
		return GetRandom ();
#else
	return -1;
#endif
	}
}
