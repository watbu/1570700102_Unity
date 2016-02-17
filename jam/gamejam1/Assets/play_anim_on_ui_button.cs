using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class play_anim_on_ui_button : MonoBehaviour 
{
	
	public Button Text;
	public Canvas yourcanvas;
	
	
	
	void Start () 
	{
		Text = Text.GetComponent<Button> ();
		yourcanvas.enabled = false;
	}
	
	
	public void Press() 
		
	{
		Text.enabled = true;
		yourcanvas.enabled = true;

		//Destroy(Text,1);

		
	}
}
