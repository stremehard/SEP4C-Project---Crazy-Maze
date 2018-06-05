using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MiddleRegion2 : MonoBehaviour
{

	public Text tutorial;

	void Start ()
	{

	}



	void OnTriggerEnter(Collider other) 
	{

		if (other.tag == "Player")
		{
			tutorial.text = "The path splits and we don't have natural elements to check on. Press the Mark button to leave a banana on the path you came from, so you can remember on your way back!";
			Destroy(gameObject);
		}

	}
}
