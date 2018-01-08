using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefinirSprite : MonoBehaviour
{
	private SpriteRenderer __visuel;

	public Sprite __vol,
				  __mannequin_challenge;

	private Dictionary <string, Sprite> __formes;


	void Start ()
	{
		__visuel = GetComponent <SpriteRenderer> ();

		__formes = new Dictionary <string, Sprite> ();


		__formes.Add ("Vol", __vol);
		__formes.Add ("Mannequin", __mannequin_challenge);
	}
	
	void Update ()
	{
		
	}

	public void DefinirVisuel(string forme)
	{
		__visuel.sprite = __formes[forme];
	}
}
