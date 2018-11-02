using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class playerMovement : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public float jumpSpeed;
	public bool isGrounded;
	public cameraMovement cam;

	public void Start(){
	
		rb = GetComponent<Rigidbody> ();

	}

	public void Update(){
	
		float movX = Input.GetAxisRaw("Horizontal") * speed;
		float movZ = Input.GetAxisRaw ("Vertical") * speed;
		float jump = Input.GetAxisRaw ("Jump") * jumpSpeed;

		rb.velocity = transform.forward * movZ + transform.right * movX;


		if (isGrounded && Input.GetKey (KeyCode.Space)) {

			rb.velocity = new Vector3 (0, jump, 0);
			isGrounded = false;

		}

		transform.rotation = new Quaternion (0, cam.gameObject.transform.rotation.y, 0, 1);

	}

	public void OnCollisionEnter(Collision other){

			isGrounded = true;
		
	}
		
}
