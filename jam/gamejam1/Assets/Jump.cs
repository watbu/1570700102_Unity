using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody>();
	}


}