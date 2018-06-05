using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript8 : MonoBehaviour {


	bool _cardButtonDown8;

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

		if (_cardButtonDown8) 
		{
			gameController.CardSelected8 ();
		}

	}

	public void OnCardButtonDown8 (bool down)
	{
		_cardButtonDown8 = down;
	}

}