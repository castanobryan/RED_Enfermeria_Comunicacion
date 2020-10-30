using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llena : MonoBehaviour {

	private int Sorter;
	public GameObject Minigames, Cross1, Cross2, volver1, volver2, ButtonPrevNav;

	//Selecciona una Pregunta de forma aleatoria para iniciar el crucigrama
	public void Sort()
	{
		ButtonPrevNav.SetActive (false);
		Minigames.SetActive (false);
		Sorter = (int)Random.Range (1f, 3f);
		if (Sorter == 1) 
		{
			Cross1.SetActive (true);
			volver1.SetActive (true);
		} 
		else if (Sorter == 2) 
		{
			volver2.SetActive (true);
			Cross2.SetActive (true);
		}
	}
}
