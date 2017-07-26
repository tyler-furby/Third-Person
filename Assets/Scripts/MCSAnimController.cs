using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCSAnimController : MonoBehaviour {

	private Animator anim;
	private float walking;
	private float turning;
	private float walkingback;

	public int turnSpeed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		walking = 0.0f;
		walkingback = 0.0f;
		turning = 0.0f;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		walking = Input.GetAxis ("Vertical");
		anim.SetFloat ("walking", walking);

		turning = Input.GetAxis ("Horizontal");
		transform.Rotate (new Vector3 (0.0f, turnSpeed * turning * Time.deltaTime));

		walkingback = Input.GetAxis ("Vertical");
		anim.SetFloat ("walkingback", walkingback);
}

}
