//C#
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public int startX,startY;
	public bool center;

	void OnGUI () {
		if (center) {
			startX = Screen.width / 2;
			startY = Screen.height / 2;
		}
		// Make a background box
		GUI.Box(new Rect(startX,startY,100,90), "Gunistan");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(startX + 10,startY + 30,80,20), "New Game")) {
			SceneManager.LoadScene ("new");
		}

		// Make the second button.
		//if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
		//	Application.LoadLevel(2);
		//}
	}
}

