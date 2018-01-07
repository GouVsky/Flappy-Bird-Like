using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefinirSprite : MonoBehaviour
{
	private SpriteRenderer __visuel;


	void Start ()
	{
		__visuel = GetComponent <SpriteRenderer> ();
	}
	
	void Update ()
	{
		
	}

	public void DefinirVisuel(Sprite sprite)
	{
		__visuel.sprite = sprite;
	}
}
