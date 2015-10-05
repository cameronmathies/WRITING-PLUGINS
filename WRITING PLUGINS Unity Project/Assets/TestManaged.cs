using UnityEngine;
using System.Collections;

public class TestManaged : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RandomNumber.MyClass obj = new RandomNumber.MyClass ();
		print ("managed Random Number: " + obj.GetRandom());
	}
	

}
