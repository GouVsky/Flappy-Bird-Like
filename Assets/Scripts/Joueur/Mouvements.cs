using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
	public float _puissance_saut;


	private Animator __animator;

	private Rigidbody2D __rigid_body;



	void Start()
	{
		__rigid_body = GetComponent <Rigidbody2D> ();

		__animator = GetComponent <Animator> ();
	}




	void FixedUpdate()
	{
		if (Input.GetKey (KeyCode.Space))
		{
			__rigid_body.velocity = Vector3.up * _puissance_saut;

			__animator.SetTrigger ("Vol");
		}
	}
}
