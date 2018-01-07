using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
	public float _puissance_saut;


	public Rigidbody __rigid_body;

	public DefinirSprite __sprite;

	public Sprite __vol,
				  __mannequin_challenge;



	void Start()
	{
		__rigid_body = GetComponent <Rigidbody> ();

		__sprite.DefinirVisuel (__mannequin_challenge);
	}
	
	void Update()
	{
		if (Input.GetKey (KeyCode.Space))
		{
			__rigid_body.velocity = Vector3.up * _puissance_saut;

			__sprite.DefinirVisuel (__vol);
		} 

		else
		{
			__sprite.DefinirVisuel (__mannequin_challenge);
		}
	}
}
