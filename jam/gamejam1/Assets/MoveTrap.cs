using UnityEngine;
using System.Collections;

public class MoveTrap : MonoBehaviour {
	public float moveSpeed;
	public GameObject SS;
	public Vector3 GetTrap;
	public Vector3 MoveWarp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
	}

	void OnCollisionStay(Collision other)
	{

		if (other.collider.tag == "Wall") 
		{

			 Vector3 MoveWarp = new Vector3(5.94f, 2.374f, 0f);
			 
		}

		 }
	}
