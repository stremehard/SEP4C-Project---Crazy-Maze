using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript9 : MonoBehaviour {


	bool _endButtonDown9;

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

		if (_endButtonDown9) 
		{
			gameController.EndSelected9 ();
		}

	}

	public void OnEndButtonDown9 (bool down)
	{
		_endButtonDown9 = down;
	}

}