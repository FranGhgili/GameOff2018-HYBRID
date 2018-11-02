using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

	public float Y_CLAMP_MAX = 0;
	public float Y_CLAMP_MIN = 70;


	public Transform lookAt;

	float CurrentX;
	float CurrentY;
	public float dist = 0;
	public float sensibilidad = 4;

	private void Update()
	{

		CurrentX += Input.GetAxis("Mouse X") * sensibilidad;
		CurrentY += Input.GetAxis("Mouse Y") * sensibilidad;

		CurrentY = Mathf.Clamp(CurrentY, Y_CLAMP_MIN, Y_CLAMP_MAX);


	}

	private void LateUpdate()
	{

		Quaternion rot = Quaternion.Euler(-CurrentY * 180, CurrentX * 180, 0);
		Quaternion rotPlayer = Quaternion.Euler(CurrentY * 180, CurrentX * 180, 0);

		transform.rotation = rot;

	}
}
