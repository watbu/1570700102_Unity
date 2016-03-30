using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bomb : MonoBehaviour {
	public GameObject playerExplosion;
	public GameObject SASASASASAS;
	public Button Text;
	public GameObject textButton;


	public bool ffafafafafafasf;
	void Start () 
	{
	
		Text = Text.GetComponent<Button> ();
		textButton.SetActive (false);

	

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			Destroy (SASASASASAS.gameObject);
			Text.enabled = true;
			textButton.SetActive (true);

			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);


		}



	}
	public void DoClick ()
	{
		Application.LoadLevel("gamejam1");
	}

}