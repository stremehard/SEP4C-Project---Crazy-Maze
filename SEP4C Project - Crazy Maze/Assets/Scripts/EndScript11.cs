using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript11 : MonoBehaviour {


	bool _endButtonDown11;

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

		if (_endButtonDown11) 
		{
			gameController.EndSelected11 ();
		}

	}

	public void OnEndButtonDown11 (bool down)
	{
		_endButtonDown11 = down;
	}

}
