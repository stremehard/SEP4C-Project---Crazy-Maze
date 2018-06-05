using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript3 : MonoBehaviour {


	bool _cardButtonDown3;

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

		if (_cardButtonDown3) 
		{
			gameController.CardSelected3 ();
		}

	}

	public void OnCardButtonDown3 (bool down)
	{
		_cardButtonDown3 = down;
	}

}