using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript4 : MonoBehaviour {


	bool _cardButtonDown4;

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

		if (_cardButtonDown4) 
		{
			gameController.CardSelected4 ();
		}

	}

	public void OnCardButtonDown4 (bool down)
	{
		_cardButtonDown4 = down;
	}

}