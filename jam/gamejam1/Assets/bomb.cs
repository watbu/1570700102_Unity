using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bomb : MonoBehaviour {
	public GameObject playerExplosion;
	public GameObject SASASASASAS;
	public Button Text;
	public Canvas yourcanvas;

	public bool ffafafafafafasf;
	void Start () 
	{
		Text = Text.GetComponent<Button> ();
		yourcanvas.enabled = false;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			Destroy (SASASASASAS.gameObject);
			Text.enabled = true;
			yourcanvas.enabled = true;

			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);


		}



	}
	public void DoClick ()
	{
		Application.LoadLevel("gamejam1");
	}

}