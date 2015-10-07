using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class TestNative : MonoBehaviour {



	void Start () {
		print ("Native Random Number: " + RandomNumberWrapper.GetRandNum());
	}
}
