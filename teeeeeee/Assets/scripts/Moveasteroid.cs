﻿using UnityEngine;
using System.Collections;

public class Moveasteroid : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity =transform.up *speed;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}