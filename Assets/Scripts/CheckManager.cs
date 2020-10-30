using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckManager : MonoBehaviour {

	public InputField Input1, Input2, Input3, Input4, Input5, Input6, Input7, Input8, Input9, Input10, Input11, Input12, Input13, Input14, Input15, Input16, Input17, Input18, Input19, Input20,
	                  Input21, Input22, Input23, Input24, Input25, Input26, Input27, Input28, Input29, Input30, Input31, Input32, Input33, Input34, Input35, Input36, Input37, Input38, Input39, Input40, Input41,
	                  Input42, Input43, Input44, Input45, Input46, Input47, Input48, Input49;
	public string word1, word2, word3, word4, word5, word6, word7;
	private string str1, str2, str3, str4, str5, str6, str7 ;
	public Animator animcheck, animwrong;
	public GameObject VolverButton, GamePanelShow, CrossPanelHide, CrossPanelHide2, VolverNav, Menu, Minigames;
	public AudioSource source;
	public AudioClip correct;
	public AudioClip incorrect;
	

	// Controla el boton de "Enter" y revisa si la respuesta es correcta
	public void CheckCross1()
	{
		// Concatena las letras en una palabra y las compara con una palabra asignada
		str1 = Input1.text + Input2.text + Input3.text + Input4.text + Input5.text + Input6.text + Input7.text + Input8.text + Input9.text;
		str2 = Input4.text + Input10.text + Input11.text + Input12.text + Input13.text + Input14.text + Input15.text + Input16.text + Input17.text;
		str3 = Input18.text + Input19.text + Input20.text + Input21.text + Input22.text + Input23.text + Input24.text + Input25.text;
		str4 = Input26.text + Input27.text + Input28.text + Input21.text + Input29.text + Input30.text + Input31.text + Input32.text;
		str5 = Input33.text + Input34.text + Input35.text + Input36.text + Input37.text + Input38.text;
		str6 = Input39.text + Input40.text + Input25.text + Input41.text + Input42.text + Input43.text + Input34.text + Input44.text + Input17.text;
		str7 = Input45.text + Input37.text + Input46.text + Input47.text + Input48.text + Input49.text;

		if (word1==str1.ToUpper() && word2==str2.ToUpper() && word3==str3.ToUpper() && word4==str4.ToUpper() && word5==str5.ToUpper() && word6==str6.ToUpper() && word7==str7.ToUpper())
		{
			source.clip = correct;
			source.Play ();
			animcheck.Play("CorrectoAnimation");
			StartCoroutine (Salir());
		} 
		else 
		{	
			source.clip = incorrect;
			source.Play ();
			animwrong.Play("WrongAnimation");
		}
	}

	//Resetea todos los campos
	public void ResetCross()
	{
		Input1.text = "";
		Input2.text = "";
		Input3.text = "";
		Input4.text = "";
		Input5.text = "";
		Input6.text = "";
		Input7.text = "";
		Input8.text = "";
		Input9.text = "";
		Input10.text = "";
		Input11.text = "";
		Input12.text = "";
		Input13.text = "";
		Input14.text = "";
		Input15.text = "";
		Input16.text = "";
		Input17.text = "";
		Input18.text = "";
		Input19.text = "";
		Input20.text = "";
		Input21.text = "";
		Input22.text = "";
		Input23.text = "";
		Input24.text = "";
		Input25.text = "";
		Input26.text = "";
		Input27.text = "";
		Input28.text = "";
		Input29.text = "";
		Input30.text = "";
		Input31.text = "";
		Input32.text = "";
		Input33.text = "";
		Input34.text = "";
		Input35.text = "";
		Input36.text = "";
		Input37.text = "";
		Input38.text = "";
		Input39.text = "";
		Input40.text = "";
		Input41.text = "";
		Input42.text = "";
		Input43.text = "";
		Input44.text = "";
		Input45.text = "";
		Input46.text = "";
		Input47.text = "";
		Input48.text = "";
		Input49.text = "";
	}

	//Resetea las actividades para regresar al Menu
	public void ResetEverything(){
		ResetCross ();
		Menu.SetActive (true);
		Minigames.SetActive (true);
		GamePanelShow.SetActive (false);
		CrossPanelHide.SetActive (false);
	}

	//Ejecuta la funcion volver despues de 6 Segundos
	IEnumerator Salir(){
		yield return new WaitForSeconds (6);
		Volver ();
	}

	//Controla el boton volver del crucigrama
	public void Volver(){
		ResetCross ();
		VolverNav.SetActive (true);
		VolverButton.SetActive (false);
		CrossPanelHide.SetActive (false);
		CrossPanelHide2.SetActive (false);
		GamePanelShow.SetActive (true);
	}
}
