using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = new int[5];

		array [0] = 5;
		array [1] = 7;
		array [2] = 11;
		array [3] = 3;
		array [4] = 2;

		for (int i = 0; i < 5; i++) {
			Debug.Log (array[i]);
		}
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
