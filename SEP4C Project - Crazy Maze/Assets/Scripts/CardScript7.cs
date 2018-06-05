using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript7 : MonoBehaviour {


	bool _cardButtonDown7;

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

		if (_cardButtonDown7) 
		{
			gameController.CardSelected7 ();
		}

	}

	public void OnCardButtonDown7 (bool down)
	{
		_cardButtonDown7 = down;
	}

}