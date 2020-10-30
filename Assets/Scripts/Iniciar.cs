using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iniciar : MonoBehaviour {

	public Animator animInicio, animMenu;
	public GameObject PanelInicio, PanelMenu;

	//Funcion que da inicio a la aplicacion
	public void IniciarApp()
	{
		animInicio.Play ("Iniciiar");
		StartCoroutine (AnimationIntro());
		
	}

	IEnumerator AnimationIntro(){
		yield return new WaitForSeconds (1);
		PanelMenu.SetActive (true);
		PanelInicio.SetActive (false);
		animMenu.Play ("Menu");
	}

}
