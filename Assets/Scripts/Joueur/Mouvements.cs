using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
	public float _puissance_saut;

	public Rigidbody2D __rigid_body;

	public DefinirSprite __sprite;


	void Start()
	{
		__rigid_body = GetComponent <Rigidbody2D> ();

		__sprite.DefinirVisuel ("Mannequin");
	}
	
	void Update()
	{
		if (Input.GetKey (KeyCode.Space))
		{
			__rigid_body.velocity = Vector3.up * _puissance_saut;

			__sprite.DefinirVisuel ("Vol");
		} 

		else
		{
			__sprite.DefinirVisuel ("Mannequin");
		}
	}
}
