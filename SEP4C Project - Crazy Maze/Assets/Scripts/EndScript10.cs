using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript10 : MonoBehaviour {


	bool _endButtonDown10;

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

		if (_endButtonDown10) 
		{
			gameController.EndSelected10 ();
		}

	}

	public void OnEndButtonDown10 (bool down)
	{
		_endButtonDown10 = down;
	}

}