using UnityEngine;
using System.Collections;

public class MoveButtonPressed : MonoBehaviour {

	void OnGUI () {

		string x="0", y="0";

		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Displacement");

		GUI.TextField ( new Rect (20,20,80,20), x, 40);
		GUI.TextField ( new Rect (20,30,80,20), y, 40);
		// Make the first button. If it is pressed, ball moves
		if(GUI.Button(new Rect(20,40,80,20), "Test")) {
			rigidbody2D.AddForce (new Vector2 (float.Parse(x),float.Parse (y)));
		}
		
	}
}

