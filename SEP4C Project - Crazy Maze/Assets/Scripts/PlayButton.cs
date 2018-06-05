using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//when button is pressed,  main menu screen is modified

public class PlayButton : MonoBehaviour
{
	bool _playButtonDown;

	public GameObject play;
	public GameObject custom;
	public GameObject tutorial;
	public GameObject help;
	public GameObject back;
	public GameObject desert;
	public GameObject winter;
	public GameObject garden;

	// Update is called once per frame
	public void Play ()
	{

		if (_playButtonDown) 
		{
			play.gameObject.SetActive (false);
			custom.gameObject.SetActive (false);
			tutorial.gameObject.SetActive (false);
			help.gameObject.SetActive (false);

			back.gameObject.SetActive (true);
			desert.gameObject.SetActive (true);
			winter.gameObject.SetActive (true);
			garden.gameObject.SetActive (true);
		}
	}

	public void OnPlayButtonDown (bool down)
	{
		_playButtonDown = down;
		Play ();
	}

}