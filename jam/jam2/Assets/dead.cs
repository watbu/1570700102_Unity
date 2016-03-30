using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class dead : MonoBehaviour {
	public Text Restarttxt;
	public Text GameOvertxt; 
	private bool GameOver;
	private bool Restart;
	// Use this for initialization
	void Start () {
		GameOver = false;
		Restart = false;
		GameOvertxt.text = "";
		Restarttxt.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (GameOver) {
			Restart = true;
			
			Restarttxt.text = "Press 'R' for Restart!!";
		}
		
		if (Restart) {
			if(Input.GetKeyDown (KeyCode.R)){
				Application.LoadLevel (Application.loadedLevel);
			}
			
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			Destroy(other.gameObject);

			GameOver= true;
			Restart = true;
			GameOvertxt.text = "Game Over!!";

		}
	}
}
