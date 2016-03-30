using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject aaaaa;
	public GameObject someObject;
	public int Valure;
	public float spawnWait;
	public float starWait;
	public float waveWait;
	public Text ScoreText;
	public int Score; 
	public Vector3 spawnPosition;
	// Use this for initialization
	void Start () {

		StartCoroutine(con());
		Score = 0;
		UpdateScore();
	}

	public void AddScore(int ScoreAdd)
	{

		Score += ScoreAdd;
		UpdateScore ();


	}
	public void MinusScore(int ScoreMinus)
	{
		
		Score =Score - ScoreMinus;
		UpdateScore ();
		
		
	}


	public void UpdateScore()
	{
		ScoreText.text = "Score : " + Score.ToString ();
	}

	IEnumerator con()
	{
		yield return new WaitForSeconds (starWait);
while (true) {
			for (int i =0; i<Valure; i++) {

				Vector3 spwanAbslotid = new Vector3(spawnPosition.x, Random.Range(4.87f , -0.26f), spawnPosition.z);

				Instantiate (someObject,spwanAbslotid, aaaaa.transform.rotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}

	}


}
