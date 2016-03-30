using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	public Text scoreText;
	private int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider c){
			score += 1;
			scoreText.text = "Score : " + score;
			scoreText.text = score.ToString ();

	}
}
