using UnityEngine;
using System.Collections;

public class destroybycontract : MonoBehaviour {

	void Start(){
	}
	void Update(){
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "boundary") {
			return;
		} else
			Destroy (other.gameObject);
		Destroy (gameObject);﻿
	}
}
