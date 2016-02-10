using UnityEngine;
using System.Collections;

public class destroybycontract : MonoBehaviour {

	void Start(){
	}
	void Update(){
	}
	public GameObject explosion;
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "boundary") {
			return;
		} else
			Instantiate(shot, shotSpawn.transform.position,shotSpawn.transform.rotation);
			Destroy (other.gameObject);
		Destroy (gameObject);﻿
	}
}
