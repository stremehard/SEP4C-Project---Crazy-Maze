using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript12 : MonoBehaviour {


	bool _cardButtonDown12;

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

		if (_cardButtonDown12) 
		{
			gameController.CardSelected12 ();
		}

	}

	public void OnCardButtonDown12 (bool down)
	{
		_cardButtonDown12 = down;
	}

}