using UnityEngine;
using System.Collections;

public class MoveTrap : MonoBehaviour {

	public float moveSpeed;
	public GameObject SS;
	public Vector3 GetTrap;
	public GameObject aaaaa;
	public GameObject someObject;
	private float nexttime;
	public float time;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
	}




}
