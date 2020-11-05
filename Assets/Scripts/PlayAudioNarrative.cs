using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioNarrative : MonoBehaviour {

	public AudioSource audi;

	//Obtiene un audio como parametro y ejecuta el sonido
	public void PlayNarrative (AudioClip aud)
	{
		audi.clip = aud;
		audi.Play ();
	}
}
