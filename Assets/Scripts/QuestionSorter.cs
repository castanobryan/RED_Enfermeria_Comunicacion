using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionSorter : MonoBehaviour {

	private string Question1 = "¿Cuáles son los principios de la práctica profesional que se deben fortalecer en la narrativa?";
	private string Question2 = "¿Qué principios éticos a la luz de la ley 911 del 2004 se encuentran vulnerados en la paciente?";
	private string Question3 = "¿Qué principios éticos a la luz de la ley 266 del 1996 plantearia para brindar un cuidado de enfermería con humanización?";
	private string Question4 = "¿Cómo puedo contribuir en el cambio de estereotipos sobre la vejez desde la comunicación e interacción con el adulto mayor?";
	private string Question5 = "¿Qué sentimientos genera en usted como ser humano y enfermero esta narrativa?";
	public Text Q1, Q2, Q3;
	public Animator TxtQ1, TxtQ2, TxtQ3;
	private int Sorter, Sortemp1, Sortemp2;
	public GameObject Mostrar1, Mostrar2, Mostrar3, Vaso1, Vaso2, Vaso3, Vaso4, Continuar, TextoPanel1, TextoPanel2, TextoPanel3;
	public Animator anim1, anim2, anim3, animSlider, animTitle;
	public Button ButtonNext, ButtonPrev, LastMostrar;

	//Realiza la seleccion de la 1ra pregunta de forma aleatoria y realiza una animacion
	public void SorterGlassOne ()
	{
		Sorter = (int)Random.Range (1f, 6f);
		if (Sorter == 1) { Q1.text = Question1; } 
		else if (Sorter == 2) { Q1.text = Question2; } 
		else if (Sorter == 3) { Q1.text = Question3; } 
		else if (Sorter == 4) { Q1.text = Question4; } 
		else if (Sorter == 5) { Q1.text = Question5; }
		Sortemp1 = Sorter;
		StartCoroutine (WaitAnimationGlass1());
	}

	//Realiza la seleccion de la 2da pregunta de forma aleatoria y realiza una animacion
	public void SorterGlassTwo ()
	{	
		//Si selecciona la misma pregunta que la anterior, vuelve a seleccionar
		do { Sorter = (int)Random.Range (1f, 6f); } 
		while (Sorter == Sortemp1);
		if (Sorter == 1) { Q2.text = Question1; } 
		else if (Sorter == 2) {	Q2.text = Question2; } 
		else if (Sorter == 3) {	Q2.text = Question3; } 
		else if (Sorter == 4) {	Q2.text = Question4; } 
		else if (Sorter == 5) { Q2.text = Question5; }
		Sortemp2 = Sorter;
		StartCoroutine (WaitAnimationGlass2());
	}

	//Realiza la seleccion de la 3ra pregunta de forma aleatoria y realiza una animacion
	public void SorterGlassThree ()
	{	
		//Si selecciona la misma pregunta que las anteriores, vuelve a seleccionar
		do { Sorter = (int)Random.Range (1f, 6f); } 
		while (Sorter == Sortemp1 || Sorter == Sortemp2);
		if (Sorter == 1) { Q3.text = Question1;	} 
		else if (Sorter == 2) {	Q3.text = Question2; } 
		else if (Sorter == 3) {	Q3.text = Question3; } 
		else if (Sorter == 4) {	Q3.text = Question4; }
		else if (Sorter == 5) {	Q3.text = Question5; }
		StartCoroutine (WaitAnimationGlass3());
	}

	//Muestra la pregunta 1
	public void ShowQuestion1()
	{
		TextoPanel1.SetActive (true);
		TxtQ1.Play ("ShowQuestion");
		animSlider.Play ("SliderAnimationRight2");
		Mostrar1.SetActive (false);
		Vaso1.SetActive (false);
		Vaso2.SetActive (true);
	}

	//Muestra la pregunta 2
	public void ShowQuestion2()
	{
		TextoPanel2.SetActive (true);
		TxtQ2.Play ("ShowQuestion");
		animSlider.Play ("SliderAnimationRight3");
		Mostrar2.SetActive (false);
		Vaso2.SetActive (false);
		Vaso3.SetActive (true);

	}

	//Muestra la pregunta 3
	public void ShowQuestion3()
	{
		TextoPanel3.SetActive (true);
		TxtQ3.Play ("ShowQuestion");
		animSlider.Play ("SliderAnimationRight4");
		ButtonNext.interactable = true;
		ButtonPrev.interactable = true;
		LastMostrar.interactable = false;
		Continuar.SetActive (true);
		Vaso3.SetActive (false);
		Vaso4.SetActive (true);
	}

	public void ResetPreguntas()
	{
		Continuar.SetActive (false);
		Vaso1.SetActive (true);
		Vaso2.SetActive (false);
		Vaso3.SetActive (false);
		Vaso4.SetActive (false);
		LastMostrar.interactable = true;
		Mostrar1.SetActive (false);
		Mostrar2.SetActive (false);
		Mostrar3.SetActive (false);
		TextoPanel1.SetActive (false);
		TextoPanel2.SetActive (false);
		TextoPanel3.SetActive (false);
	}

	//Ejecuta Animacion y muestra boton de pregunta 1
	IEnumerator WaitAnimationGlass1() 
	{
		anim1.Play ("VasoBigAnimation");
		Mostrar1.SetActive (false);
		yield return new WaitForSeconds (2);
		Mostrar1.SetActive (true);
	}

	//Ejecuta Animacion y muestra boton de pregunta 2
	IEnumerator WaitAnimationGlass2() 
	{
		anim2.Play ("VasoBigAnimation");
		Mostrar2.SetActive (false);
		yield return new WaitForSeconds (2);
		Mostrar2.SetActive (true);
	}

	//Ejecuta Animacion y muestra boton de pregunta 3
	IEnumerator WaitAnimationGlass3() 
	{
		anim3.Play ("VasoBigAnimation");
		Mostrar3.SetActive (false);
		yield return new WaitForSeconds (2);
		Mostrar3.SetActive (true);
	}
}
