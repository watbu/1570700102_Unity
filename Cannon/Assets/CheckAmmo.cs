﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CheckAmmo : MonoBehaviour {
	private Controller_Button conContrller;
	private Scoreupdate conScoreupdate; 


	// Use this for initialization
	void Start () {
		GameObject isconScoreupdate = GameObject.FindGameObjectWithTag ("Scoreupdate");

		if (isconScoreupdate != null) {
			conScoreupdate = isconScoreupdate.GetComponent<Scoreupdate>();
		}
		if (isconScoreupdate == null) {
			Debug.Log("ERROR"); 
		}

	
		GameObject iscontroller = GameObject.FindGameObjectWithTag ("conNexButton");
	if(iscontroller != null)
		{
			conContrller = iscontroller.GetComponent<Controller_Button>();
		}
		if (iscontroller == null) {
			Debug.Log("Error"); 
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Wall") {
			Destroy(gameObject); 
			conContrller.shootNext = true;
		}
		if (other.gameObject.tag == "Point") {
			Destroy(gameObject);
			Destroy(other.gameObject);
			conScoreupdate.ScoreAdd();
			conContrller.shootNext = true;
		}
		if (other.gameObject.tag == "Wall4") {
			Destroy(gameObject); 
			conContrller.shootNext = true;
		}
	}



}
