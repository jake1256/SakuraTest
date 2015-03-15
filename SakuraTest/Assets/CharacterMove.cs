using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

	float forwardSpeed = 3.0f;
	float backwardSpeed = 1.0f;
	float rotateSpeed = 10.0f;
	Animator anim;
	CharacterController characterController;
	void Start () {
		anim = GetComponent<Animator>();
		characterController = GetComponent<CharacterController>();
	}
	
	void Update () {
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");

		Vector3 velocity = new Vector3(0, 0, v);
		velocity = transform.TransformDirection(velocity);
		if (v > 0) {
			velocity *= forwardSpeed;
		} else if (v < 0) {
			velocity *= backwardSpeed;
		}

		anim.SetFloat("Speed" , v);

		characterController.Move(velocity * Time.deltaTime);
		transform.Rotate(0, h * rotateSpeed, 0);

		if(Input.GetButtonDown("Jump")){
			anim.SetBool("IsSalute" , true);
		}else{
			anim.SetBool("IsSalute" , false);
		}
	}
}
