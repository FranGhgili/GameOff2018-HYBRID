using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class playerMovement : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public float jumpSpeed;
	public bool isGrounded;
	public void Start(){
	
		rb = GetComponent<Rigidbody> ();

	}

	public void Update(){
	
		float movX = Input.GetAxisRaw("Horizontal") * speed;
		float jump = Input.GetAxisRaw ("Jump") * jumpSpeed;

        if (isGrounded && Input.GetKey(KeyCode.Space))
        {

            rb.AddForce(Vector3.up * jump);
            isGrounded = false;

        }

        rb.AddForce  (Vector3.right * movX);

    }

	public void OnCollisionEnter(Collision other){

			isGrounded = true;
		
	}
		
}
