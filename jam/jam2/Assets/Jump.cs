using UnityEngine;
using System.Collections;


public class Jump : MonoBehaviour {
	public Rigidbody rb;
	public Vector3 game;
	public GameObject con;
	private bool canJump;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "cube") 
		{
			canJump = true;
		}


	}


	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "cube") 
		{
			canJump = false;
		}
		
		
	}
	

	public void ClickStart(){
		if (canJump) {
			rb.velocity = (new Vector3 (0.0f, 5f, 0.0f));
		}
	}
}
