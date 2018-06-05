using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Creates a banana game object at the position of the player (MARK button)

public class MarkButton : MonoBehaviour
{

	bool _markButtonDown;
	Vector3 startPos;
	public GameObject hazard;
	public float banana;
	public Text bananasText;


	// Update is called once per frame
	void Update ()
	{
		bananasText.text = ("Bananas Left: " + banana + " X");
		if (_markButtonDown) 
		{
			if (banana != 0)
			{
				var player = GameObject.FindGameObjectWithTag ("Player");
				startPos = player.transform.position;
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, startPos, spawnRotation);
				banana = banana - 1;
			}
	
		}
	}

	public void OnMarkButtonDown (bool down)
	{
		_markButtonDown = down;
	}

}
