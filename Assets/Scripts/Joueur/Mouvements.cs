using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
	public float _puissance_saut;

	public Rigidbody __rigid_body;


	void Start()
	{
		__rigid_body = GetComponent <Rigidbody> ();
	}
	
	void Update()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			__rigid_body.velocity = Vector3.up * _puissance_saut;//.AddForce (Vector3.up * _puissance_saut);
		}
	}
}
