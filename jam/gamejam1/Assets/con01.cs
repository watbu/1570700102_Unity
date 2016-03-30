using UnityEngine;
using System.Collections;

public class con01 : MonoBehaviour {
	public float thrust;
	public Rigidbody rb;
	public Vector3 game;


	void Start() {
		rb = GetComponent<Rigidbody>();
	}


	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "tak") {

			rb.velocity = new Vector3(0.0f,rb.velocity.y,0.0f);
			gameObject.transform.rotation = Quaternion.identity;
		}
			
			
	}
	public void ClickStart()
	{
		
		rb.velocity = (new Vector3(0.0f,5f,0.0f));
	}

}
