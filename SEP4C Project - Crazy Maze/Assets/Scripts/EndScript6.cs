using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript6 : MonoBehaviour {


	bool _endButtonDown6;

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

		if (_endButtonDown6) 
		{
			gameController.EndSelected6 ();
		}

	}

	public void OnEndButtonDown6 (bool down)
	{
		_endButtonDown6 = down;
	}

}