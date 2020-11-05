using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class BarController : MonoBehaviour {

	public GameObject PanelContent_1, PanelContent_2, PanelContent_3, PanelContent_4, PanelContent_5, Black, ButtonNext_1, ButtonPrev_2, PanelCaso, MenuPanel, Introduccion, Preguntas, Caso, Actividad, Minigames, 
	PanelPrecaso, PanelPreguntas, PanelCasoFondo, Pregunta1, Pregunta2, Pregunta3, Pregunta4, Pregunta5, Resultados, P1A, P1B, P1C, P2A, P2B, P2C, P3A, P3B, P3C, P4A, P4B, P4C, P5A, P5B, P5C, PanelPreClick, PanelPostClick;
	public Button ButtonNext, ButtonPrev;
	private int ClickCounter = 1;
	public int Counterhere, tempCounter, Preguntashere;
	public Animator animSlider, animTitle, animCaso;

	void Start ()
	{
		ButtonPrev_2.SetActive (false);
	}

	void Update ()
	{
		//Se Obtiene el valor de Counter en la Clase QuestionBegin
		QuestionBegin temp = GetComponent<QuestionBegin>();
		Counterhere = temp.Counter;

	}

	//Resetea a default las preguntas del caso
	private void ResetEverything()
	{
		Pregunta1.SetActive (true);
		Pregunta2.SetActive (false);
		Pregunta3.SetActive (false);
		Pregunta4.SetActive (false);
		Pregunta5.SetActive (false);
		Resultados.SetActive (false);
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

	//Boton que controla la vuelta al Menu
	public void BackMenu()
	{
		ButtonNext_1.SetActive (false);
		ButtonPrev_2.SetActive (false);
		MenuPanel.SetActive (true);
		Introduccion.SetActive (false);
		Preguntas.SetActive (false);
		Caso.SetActive (false);
		Actividad.SetActive (false);
		PanelCaso.SetActive (false);
		PanelPrecaso.SetActive (true);
		PanelCasoFondo.SetActive (false);
		PanelPreguntas.SetActive (false);
		ResetEverything ();
	}

	//Funciones que controlan los botones del Menu
	public void ClickIntroduccion()
	{
		ClickCounter = 1;
		animTitle.Play ("TitleIntroBack");
		animSlider.Play ("SliderAnimationBack3");
		MenuPanel.SetActive (false);
		Introduccion.SetActive (true);
		ButtonNext.interactable = true;
		ButtonPrev_2.SetActive (false);
	}

	public void ClickPreguntas()
	{
		ClickCounter = 2;
		animSlider.Play ("SliderAnimation");
		animTitle.Play ("TitleIntro");
		ButtonPrev_2.SetActive (true);
		MenuPanel.SetActive (false);
		Preguntas.SetActive (true);
		PanelPreClick.SetActive (true);
		PanelPostClick.SetActive (false);
		ButtonPrev.interactable = true;
		ButtonNext.interactable = true;
	}

	public void ClickNarrativa()
	{
		ClickCounter = 3;
		animSlider.Play("SliderAnimationRight5");
		animTitle.Play ("TitlePreguntas");
		ButtonNext.interactable = false;
		ButtonPrev.interactable = true;
		ButtonPrev_2.SetActive (true);
		MenuPanel.SetActive (false);
		Caso.SetActive (true);
	}

	public void ClickActividad()
	{
		ClickCounter = 4;
		animTitle.Play ("TitleCaso");
		animSlider.Play ("SliderAnimationRight7");
		ButtonPrev_2.SetActive (true);
		ButtonPrev.interactable = false;
		ButtonNext.interactable = false;
		MenuPanel.SetActive (false);
		Actividad.SetActive (true);
		Minigames.SetActive (true);
	}


	
	//Funcion para Controlar Clic en boton "Siguiente"	
	public void NextContent()
	{
		ClickCounter++;
		if (ClickCounter == 2) 
		{	//Preguntas
			ButtonPrev_2.SetActive (true);
			PanelContent_1.SetActive (false);
			PanelContent_2.SetActive (true);
			animSlider.Play ("SliderAnimation");
			animTitle.Play ("TitleIntro");	
		} 
		else if (ClickCounter == 3) 
		{ 	//Caso
			PanelContent_2.SetActive (false);
			PanelPrecaso.SetActive (true);
			PanelPreguntas.SetActive (false);
			ResetEverything ();
			PanelContent_3.SetActive (true);
			animSlider.Play("SliderAnimationRight5");
			animTitle.Play ("TitlePreguntas");
			if (Counterhere == 1) { ButtonNext.interactable = true; } 
			else if (Counterhere == 0) { ButtonNext.interactable = false; }
		} 
		else if (ClickCounter == 4) 
		{	//Evaluacion
			tempCounter = 1;
			ButtonNext_1.SetActive (false);
			PanelContent_3.SetActive (false);
			PanelContent_4.SetActive (true);
			Minigames.SetActive (true);
			animTitle.Play ("TitleCaso");
			animSlider.Play ("SliderAnimationRight7");
			ButtonPrev.interactable = false;
			ButtonNext.interactable = false;
			ButtonPrev_2.SetActive (true);
		} 	
	}

	//Funcion para Controlar Clic en boton "Anterior"
	public void PreviewContent ()
	{
		ClickCounter--;
		if (ClickCounter == 1) 
		{	//Introduccion
			ButtonPrev_2.SetActive (false);
			PanelContent_1.SetActive (true);
			PanelContent_2.SetActive (false);
			animTitle.Play ("TitleIntroBack");
			animSlider.Play ("SliderAnimationBack3");
			if (Counterhere == 1) {
				ButtonNext.interactable = false;
			} else if (Counterhere == 0) {
				ButtonNext.interactable = true;
			}
		} else if (ClickCounter == 2) 
		{	//Preguntas
			PanelContent_2.SetActive (true);
			PanelContent_3.SetActive (false);
			animTitle.Play ("TitlePreguntasBack");
			animSlider.Play ("SliderAnimationBack2");
			if (Counterhere == 1) {
				ButtonNext.interactable = false; 
			} else {
				ButtonNext.interactable = true; 
			}
		} 
		else if (ClickCounter == 3) 
		{
			//Caso
			PanelContent_3.SetActive (true);
			PanelContent_4.SetActive (false);
			animSlider.Play ("SliderAnimationBack1");
			PanelPrecaso.SetActive (true);
			ResetEverything ();
			ButtonNext_1.SetActive (true);
			PanelCaso.SetActive (false);
			if (tempCounter == 1) { 
				ButtonPrev.interactable = false; 
				ButtonNext.interactable = true;
			}
		}
	}

	//Funcion para Controlar el boton "Continuar" en Preguntas Generadoras
	public void ContinuarButton (){
		ClickCounter++;
		PanelContent_2.SetActive (false);
		PanelContent_3.SetActive (true);
		animSlider.Play("SliderAnimationRight5");
		animTitle.Play ("TitlePreguntas");
		ButtonNext.interactable = false;
		ButtonPrev.interactable = true;
	}

	//Funcion para cerrar la aplicacion
	public void Salir(){
		Application.Quit ();
	}

	//Funcion para descargar el PDF
	public void Download(){
		Application.OpenURL ("https://mailunicundiedu-my.sharepoint.com/:b:/g/personal/ahernandezb_ucundinamarca_edu_co/EeErnTdJvv9DragrQehDseEBwGiDKmjG1I7TxgFHyujGpw?e=zJ0OMz");
	}

	//Funciona para descargar el PDF de la Narrativa
	public void DownloadNarrativa(){
		Application.OpenURL ("https://mailunicundiedu-my.sharepoint.com/:b:/g/personal/ahernandezb_ucundinamarca_edu_co/ESJNbyXWi5NJgZLMMSejQF8BXPYDN_fo3sUMHxwFTuR9GQ?e=IRi6bu");
	}

}
