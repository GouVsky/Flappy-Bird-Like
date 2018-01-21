using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementTuyaux : MonoBehaviour
{
	public float _vitesse;

	
	void Start ()
	{
		
	}




	void Update ()
	{
		Vector3 nouvelle_position = transform.position - new Vector3 (_vitesse, 0, 0);

		transform.position = nouvelle_position;
	}
}
