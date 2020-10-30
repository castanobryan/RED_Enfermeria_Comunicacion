using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioNarrative : MonoBehaviour {

	public AudioSource audio;

	//Obtiene un audio como parametro y ejecuta el sonido
	public void PlayNarrative (AudioClip aud)
	{
		audio.clip = aud;
		audio.Play ();
	}
}
