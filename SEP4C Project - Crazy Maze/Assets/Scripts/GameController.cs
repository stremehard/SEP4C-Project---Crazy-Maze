using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//in charge of goals events such as item selection, start, finish regions, game over etc.

public class GameController : MonoBehaviour {


	public AudioClip audWin;
	private AudioSource audioSource;

	private Timer timer;
	public Text objective;

	private float card;
	private float selection;

	public GameObject WallFinish;

	public GameObject playerObject;

	public GameObject controllerX;

	public Button CardButton1;
	public Button CardButton2;
	public Button CardButton3;
	public Button CardButton4;
	public Button CardButton5;
	public Button CardButton6;
	public Button CardButton7;
	public Button CardButton8;
	public Button CardButton9;
	public Button CardButton10;
	public Button CardButton11;
	public Button CardButton12;

	public Button EndButton1;
	public Button EndButton2;
	public Button EndButton3;
	public Button EndButton4;
	public Button EndButton5;
	public Button EndButton6;
	public Button EndButton7;
	public Button EndButton8;
	public Button EndButton9;
	public Button EndButton10;
	public Button EndButton11;
	public Button EndButton12;

	private GameObject des;

	void Start ()
	{
		audioSource = GetComponent<AudioSource > ();

		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		des.SetActive (false);



		GameObject TimerObject = GameObject.FindWithTag ("Timer");
		timer = TimerObject.GetComponent <Timer>();


	}

	// Update is called once per frame
	void Update () {
		
	}


	public void CardSelected1()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 1;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected2()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 2;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected3()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 3;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected4()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 4;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected5()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 5;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected6()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 6;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected7()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 7;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected8()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 8;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected9()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 9;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected10()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 10;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected11()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 11;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}
	public void CardSelected12()
	{
		CardButton1.gameObject.SetActive (false);
		CardButton2.gameObject.SetActive (false);
		CardButton3.gameObject.SetActive (false);
		CardButton4.gameObject.SetActive (false);
		CardButton5.gameObject.SetActive (false);
		CardButton6.gameObject.SetActive (false);
		CardButton7.gameObject.SetActive (false);
		CardButton8.gameObject.SetActive (false);
		CardButton9.gameObject.SetActive (false);
		CardButton10.gameObject.SetActive (false);
		CardButton11.gameObject.SetActive (false);
		CardButton12.gameObject.SetActive (false);

		card = 12;
		timer.StartCoroutine("LoseTime");
		objective.text = ("Goal: go to the start of the maze!");
		controllerX.gameObject.SetActive (true);
		GameObject des = GameObject.Find ("Wall Horizontal (256)");
		Destroy (des);
	}

	public void EndSelected1()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 1;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
			 }
	}
	public void EndSelected2()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 2;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected3()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 3;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected4()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 4;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected5()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 5;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected6()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 6;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected7()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 7;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected8()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 8;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected9()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 9;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected10()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 10;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected11()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 11;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}
	public void EndSelected12()
	{
		EndButton1.gameObject.SetActive (false);
		EndButton2.gameObject.SetActive (false);
		EndButton3.gameObject.SetActive (false);
		EndButton4.gameObject.SetActive (false);
		EndButton5.gameObject.SetActive (false);
		EndButton6.gameObject.SetActive (false);
		EndButton7.gameObject.SetActive (false);
		EndButton8.gameObject.SetActive (false);
		EndButton9.gameObject.SetActive (false);
		EndButton10.gameObject.SetActive (false);
		EndButton11.gameObject.SetActive (false);
		EndButton12.gameObject.SetActive (false);

		selection = 12;
		if (selection == card) {
			objective.text = ("Congratulations! Level Completed!");
		} 
		else {
			objective.text = ("Game Over! Try again!");
			Destroy (playerObject);
		}
	}


	public void FinishRegion()
	{
	
		WallFinish.gameObject.SetActive (true);

		controllerX.gameObject.SetActive (false);
		GameObject go = GameObject.Find ("Wall Horizontal (255)");
		go.SetActive (false);
		audioSource.PlayOneShot (audWin, 0.6F);
		objective.text = ("Goal: choose one item you like!");

		CardButton1.gameObject.SetActive (true);
		CardButton2.gameObject.SetActive (true);
		CardButton3.gameObject.SetActive (true);
		CardButton4.gameObject.SetActive (true);
		CardButton5.gameObject.SetActive (true);
		CardButton6.gameObject.SetActive (true);
		CardButton7.gameObject.SetActive (true);
		CardButton8.gameObject.SetActive (true);
		CardButton9.gameObject.SetActive (true);
		CardButton10.gameObject.SetActive (true);
		CardButton11.gameObject.SetActive (true);
		CardButton12.gameObject.SetActive (true);

	}

	public void StartRegion()
	{

		audioSource.PlayOneShot (audWin, 0.6F);
		timer.StopCoroutine("LoseTime");
		objective.text = ("Goal: choose your item's number!");

		EndButton1.gameObject.SetActive (true);
		EndButton2.gameObject.SetActive (true);
		EndButton3.gameObject.SetActive (true);
		EndButton4.gameObject.SetActive (true);
		EndButton5.gameObject.SetActive (true);
		EndButton6.gameObject.SetActive (true);
		EndButton7.gameObject.SetActive (true);
		EndButton8.gameObject.SetActive (true);
		EndButton9.gameObject.SetActive (true);
		EndButton10.gameObject.SetActive (true);
		EndButton11.gameObject.SetActive (true);
		EndButton12.gameObject.SetActive (true);

	}

	public void TimerOver()
	{
		objective.text = ("Game Over! Try again!");
		Destroy (playerObject);
	}
}
