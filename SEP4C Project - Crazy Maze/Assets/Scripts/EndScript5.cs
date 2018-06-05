using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript5 : MonoBehaviour {


	bool _endButtonDown5;

	private GameController gameController;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

		if (gameControllerObject != null)

		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}

		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void Update ()
	{

		if (_endButtonDown5) 
		{
			gameController.EndSelected5 ();
		}

	}

	public void OnEndButtonDown5 (bool down)
	{
		_endButtonDown5 = down;
	}

}