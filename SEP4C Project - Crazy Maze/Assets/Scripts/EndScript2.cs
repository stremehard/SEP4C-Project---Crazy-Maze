using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript2 : MonoBehaviour {


	bool _endButtonDown2;

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

		if (_endButtonDown2) 
		{
			gameController.EndSelected2 ();
		}

	}

	public void OnEndButtonDown2 (bool down)
	{
		_endButtonDown2 = down;
	}

}