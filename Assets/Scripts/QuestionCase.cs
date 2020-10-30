using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCase : MonoBehaviour {

	public GameObject Pregunta1, Pregunta2, Pregunta3, Pregunta4, Pregunta5, Resultados, P1A, P1B, P1C, P2A, P2B, P2C, P3A, P3B, P3C, P4A, P4B, P4C, P5A, P5B, P5C;
	public Button ButtonNext, ButtonPrev;


	//Controla las respuestas de las preguntas y muestra cuales se eligieron
	public void Pregunta1A()
	{
		Pregunta1.SetActive (false);
		Pregunta2.SetActive (true);
		P1A.SetActive(true);
	}

	public void Pregunta1B()
	{
		Pregunta1.SetActive (false);
		Pregunta2.SetActive (true);
		P1B.SetActive(true);
	}

	public void Pregunta1C()
	{
		Pregunta1.SetActive (false);
		Pregunta2.SetActive (true);
		P1C.SetActive(true);
	}

	public void Pregunta2A()
	{
		Pregunta2.SetActive (false);
		Pregunta3.SetActive (true);
		P2A.SetActive(true);
	}

	public void Pregunta2B()
	{
		Pregunta2.SetActive (false);
		Pregunta3.SetActive (true);
		P2B.SetActive(true);
	}

	public void Pregunta2C()
	{
		Pregunta2.SetActive (false);
		Pregunta3.SetActive (true);
		P2C.SetActive(true);
	}

	public void Pregunta3A()
	{
		Pregunta3.SetActive (false);
		Pregunta4.SetActive (true);
		P3A.SetActive(true);
	}

	public void Pregunta3B()
	{
		Pregunta3.SetActive (false);
		Pregunta4.SetActive (true);
		P3B.SetActive(true);
	}

	public void Pregunta3C()
	{
		Pregunta3.SetActive (false);
		Pregunta4.SetActive (true);
		P3C.SetActive(true);
	}

	public void Pregunta4A()
	{
		Pregunta4.SetActive (false);
		Pregunta5.SetActive (true);
		P4A.SetActive(true);
	}

	public void Pregunta4B()
	{
		Pregunta4.SetActive (false);
		Pregunta5.SetActive (true);
		P4B.SetActive(true);
	}

	public void Pregunta4C()
	{
		Pregunta4.SetActive (false);
		Pregunta5.SetActive (true);
		P4C.SetActive(true);
	}

	public void Pregunta5A()
	{
		Pregunta5.SetActive (false);
		Resultados.SetActive (true);
		P5A.SetActive(true);
		ButtonNext.interactable = true;
	}

	public void Pregunta5B()
	{
		Pregunta5.SetActive (false);
		Resultados.SetActive (true);
		P5B.SetActive(true);
		ButtonNext.interactable = true;
	}

	public void Pregunta5C()
	{
		Pregunta5.SetActive (false);
		Resultados.SetActive (true);
		P5C.SetActive(true);
		ButtonNext.interactable = true;
		//ButtonPrev.SetActive (true);
	}

	//Resetea las respuestas y dirige al usuario a volverlas a responder
	public void Retry()
	{
		ButtonNext.interactable = false;
		Resultados.SetActive (false);
		Pregunta1.SetActive (true);
		P1A.SetActive (false);
		P1B.SetActive (false);
		P1C.SetActive (false);
		P2A.SetActive (false);
		P2B.SetActive (false);
		P2C.SetActive (false);
		P3A.SetActive (false);
		P3B.SetActive (false);
		P3C.SetActive (false);
		P4A.SetActive (false);
		P4B.SetActive (false);
		P4C.SetActive (false);
		P5A.SetActive (false);
		P5B.SetActive (false);
		P5C.SetActive (false);
	}
}
