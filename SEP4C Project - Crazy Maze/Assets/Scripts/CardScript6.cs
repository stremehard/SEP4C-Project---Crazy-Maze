using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript6 : MonoBehaviour {


	bool _cardButtonDown6;

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

		if (_cardButtonDown6) 
		{
			gameController.CardSelected6 ();
		}

	}

	public void OnCardButtonDown6 (bool down)
	{
		_cardButtonDown6 = down;
	}

}