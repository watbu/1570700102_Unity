using UnityEngine;
using System.Collections;

public class MinusScore : MonoBehaviour {

	private GameController gameController;
	public int scoreValue;
	// Use this for initialization
	void Start () {
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		
		if(gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent<GameController>();
		}
		if (gameControllerObject == null) {
			Debug.Log("Cannot find 'GameController' Script");
		}
	}
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "tak") {
			return;
		}
		if (other.tag == "Player") {
			
			gameController.MinusScore(scoreValue);
		}
	}
}
