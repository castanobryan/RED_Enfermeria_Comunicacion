using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionBegin : MonoBehaviour {

	//public Animator anim, animstop, animnext;
	public GameObject PanelFront, PanelPreclick, PanelPostClick;
	public Button ButtonNext, ButtonPrev;
	public int Counter = 0;

	//Controla el boton de iniciar en Preguntas Genradoras, ejecuta animaciones
	public void StartGame () 
	{
		PanelPostClick.SetActive (false);
		ButtonNext.interactable = false;
		ButtonPrev.interactable = false;
		PanelPreclick.SetActive (false);
		PanelPostClick.SetActive (true);
		Counter++;
	}
}
