using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

	public float runningSpeed = 0.1f;
	public float turnSpeed = 0.1f;
	public KeyCode left;
	public KeyCode right;
	public KeyCode jump;
	public KeyCode slide;
	public Animator animations;


	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		this.transform.Translate(Vector3.forward * runningSpeed);
		//this.transform.Rotate(Vector3.up * speed);
		if (Input.GetKey(left))
			this.transform.Rotate(-Vector3.up * turnSpeed);
		  
		else if (Input.GetKey(right))
			transform.Rotate(Vector3.up * turnSpeed);

		if (Input.GetKey(jump))
			animations.Play("Running Jump");

		if (Input.GetKey(slide))
			animations.Play("Running Slide");
	}
}
