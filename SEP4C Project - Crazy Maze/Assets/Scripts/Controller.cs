using UnityEngine;
using System.Collections;

//Controller for the player object ( movement buttons )

public class Controller : MonoBehaviour
{
	public Transform target;
	public float speed = 5;

	bool _rightButtonDown;
	bool _leftButtonDown;
	bool _upButtonDown;
	bool _downButtonDown;

	// Update is called once per frame
	void Update ()
	{
		if (_rightButtonDown) {
			float moveRight = (Time.deltaTime * speed);
			target.Translate (moveRight, 0, 0);
			target.transform.rotation = Quaternion.identity;
		}
		if (_leftButtonDown) {
			float moveLeft = (Time.deltaTime * speed);
			target.Translate (-moveLeft, 0, 0);
			target.transform.rotation = Quaternion.identity;
		}
		if (_upButtonDown) {
			float moveUp = (Time.deltaTime * speed);
			target.Translate (0, 0, moveUp);
			target.transform.rotation = Quaternion.identity;
		}
		if (_downButtonDown) {
			float moveDown = (Time.deltaTime * speed);
			target.Translate (0, 0, -moveDown);
			target.transform.rotation = Quaternion.identity;
		}
	}

	public void OnRightButtonDown (bool down)
	{
		_rightButtonDown = down;
	}

	public void OnLeftButtonDown (bool down)
	{
		_leftButtonDown = down;
	}

	public void OnUputtonDown (bool down)
	{
		_upButtonDown = down;
	}

	public void OnDownButtonDown (bool down)
	{
		_downButtonDown = down;
	}
}
