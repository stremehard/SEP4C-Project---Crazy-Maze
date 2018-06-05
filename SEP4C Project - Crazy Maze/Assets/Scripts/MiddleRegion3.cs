using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MiddleRegion3 : MonoBehaviour
{

	public Text tutorial;
	public GameObject middle4;

	void Start ()
	{

	}



	void OnTriggerEnter(Collider other) 
	{

		if (other.tag == "Player")
		{
			middle4.gameObject.SetActive (true);
			tutorial.text = "";
			Destroy(gameObject);
		}

	}
}

