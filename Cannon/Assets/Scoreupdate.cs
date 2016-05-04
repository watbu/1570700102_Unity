using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scoreupdate : MonoBehaviour {
	public Text Scoretxt; 
	public int Score; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
public void ScoreAdd()
	{
		Score += 1; 
		Scoretxt.text = "Score: " + Score.ToString();
		
		
		
	}
}
