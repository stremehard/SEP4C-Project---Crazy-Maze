using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Timer used to decrement when the player has to return to the start of the maze

public class Timer : MonoBehaviour
{
	public int timeLeft;
	public Text countdownText;
	private GameController gameController;

	// Use this for initialization
	void Start()
	{
		//countdownText.text = ("Crazy Maze - LVL 3");

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

	// Update is called once per frame
	void Update()
	{

		if (timeLeft <= 0)
		{
			StopCoroutine("LoseTime");
			countdownText.text = "Out of time!";
			countdownText.color = Color.red;
			gameController.TimerOver ();
		}
	}

	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
			countdownText.text = ("Time Left: " + timeLeft + " sec");
		}
	}
}