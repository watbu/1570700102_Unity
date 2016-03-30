using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ControllCube : MonoBehaviour {
	public GameObject SpawnPoint;
	public GameObject NewCube; 
	public GameObject wanrring;


	public int value;
	public float spawnWait;
	public float WaveWait;
	public float StartGame;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpwanWaves());
	}
	
	// Update is called once per frame
	void Update () {

		//Instantiate(NewCube,SpawnPoint.transform.position,SpawnPoint.transform.rotation);
	
	}
	IEnumerator SpwanWaves()
	{
		yield return new WaitForSeconds(StartGame);
		while (true) {
			for(int i = 0;i< value;i++){


				Instantiate (wanrring,SpawnPoint.transform.position,SpawnPoint.transform.rotation);
				yield return new WaitForSeconds(spawnWait);
			}
		}
	}

}
