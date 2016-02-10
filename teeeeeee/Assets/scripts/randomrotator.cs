using UnityEngine;
using System.Collections;

public class randomrotator : MonoBehaviour {
	public float tumbel;
	void Start(){
		Rigidbody rb;
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumbel;
	}

}
