﻿using UnityEngine;
using System.Collections;

public class destroyCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "cube") {
			Destroy(other.gameObject);
		}
	}
}
