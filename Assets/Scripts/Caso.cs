using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caso : MonoBehaviour {

	public GameObject Black, PanelCaso, PanelPrecaso, PanelPreguntas, PanelCasoFondo, AnimationPanel;
	public Animator anim, animCaso, animTitle, animSlider;
	public Button ButtonPrev;
	public int PreguntasTemp;

	//Esconde el panel del Precaso y Activa panel de preguntas
	IEnumerator HidePanel()
	{
		yield return new WaitForSeconds (10);
		ButtonPrev.interactable = false;
		PanelPrecaso.SetActive (false);
		PanelPreguntas.SetActive (true);
	}

	//Muestra preguntas despues que termina el caso
	IEnumerator ShowQuestions()
	{
		yield return new WaitForSeconds (200);
		animTitle.Play ("TitleCaso");
		animSlider.Play ("SliderAnimationRight6");
		PanelCasoFondo.SetActive (false);
	}

	//Ejecuta y Muestra la Animacion del Caso
	IEnumerator ShowPanel()
	{
		yield return new WaitForSeconds (6);
		PanelCaso.SetActive (true);
		animCaso.Play ("CasoAnim");
		StartCoroutine (ShowQuestions ());
		StartCoroutine (HidePanel ());
	}

	//Ejecuta Animacion de Inicio del Caso
	public void InAnimation()
	{
		Black.SetActive (true);
		anim.Play ("CasoInicio");
		PanelCasoFondo.SetActive (true);
		StartCoroutine (ShowPanel ());
	}

	//Muestra directamente las preguntas de la Narrativa
	public void InPreguntas()
	{
		animTitle.Play ("TitleCaso");
		animSlider.Play ("SliderAnimationRight6");
		PanelPreguntas.SetActive (true);
		PanelCaso.SetActive (false);
		PanelPrecaso.SetActive (false);
		ButtonPrev.interactable = false;
	}
}
