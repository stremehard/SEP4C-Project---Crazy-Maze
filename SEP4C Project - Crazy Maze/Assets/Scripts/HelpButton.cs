using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//when button is pressed,  main menu changes appearance 

public class HelpButton : MonoBehaviour
{
	bool _helpButtonDown;

	public GameObject play;
	public GameObject custom;
	public GameObject tutorial;
	public GameObject help;
	public GameObject back;
	public GameObject text;

	// Update is called once per frame
	public void Help ()
	{

		if (_helpButtonDown) 
		{
			play.gameObject.SetActive (false);
			custom.gameObject.SetActive (false);
			tutorial.gameObject.SetActive (false);
			help.gameObject.SetActive (false);

			back.gameObject.SetActive (true);
			text.gameObject.SetActive (true);
		}
	}

	public void OnHelpButtonDown (bool down)
	{
		_helpButtonDown = down;
		Help ();
	}

}