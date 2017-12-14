// Credit to damien_oconnell from http://forum.unity3d.com/threads/39513-Click-drag-camera-movement
// for using the mouse displacement for calculating the amount of camera movement and panning code.

using UnityEngine;
using System.Collections;



	


public class CameraMovement : MonoBehaviour 
{
	//
	// VARIABLES
	//





	private Vector3 panOrigin;	// Position of cursor when mouse dragging starts
	private Vector3 oldPos;
	public Camera cam;
	private float orthoZoom;
	//
	// UPDATE
	//

	void Update () 
	{
		// Get the right mouse button
		if(Input.GetMouseButtonDown(0))
		{
			oldPos = transform.position;
			panOrigin = Camera.main.ScreenToViewportPoint(Input.mousePosition);                    //Get the ScreenVector the mouse clicked
		}

		if(Input.GetMouseButton(0))
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition) - panOrigin;    //Get the difference between where the mouse clicked and where it moved
			pos = pos * 25; //It's slow as fuck for some reason so just multiply it 
			transform.position = oldPos + -pos;                                         //Move the position of the camera to simulate a drag, speed * 10 for screen to worldspace conversion
		}


		// Zooming
		var d = Input.GetAxis("Mouse ScrollWheel");
		if (d > 0f)
		{
			cam.orthographicSize--;
		}
		else if (d < 0f)
		{
			cam.orthographicSize++;
		}
		orthoZoom = cam.orthographicSize;


	




	}
}