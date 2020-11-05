using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckForAnswer : MonoBehaviour {

    public GameObject pdf, LetterOne, LetterTwo, LetterThree, LetterFour, LetterFive, LetterSix, LetterSeven, LetterEight, LetterNine, LetterTen,
					  LetterEleven, BoxOne, BoxTwo, BoxThree, BoxFour, BoxFive, BoxSix, BoxSeven, BoxEight, BoxNine, questionToHide, questionToShow, backpanel;
    
    private Vector3 LetterOneIni, LetterTwoIni, LetterThreeIni, LetterFourIni, LetterFiveIni, LetterSixIni, LetterSevenIni, LetterEightIni, LetterNineIni, LetterTenIni, LetterElevenIni;
    
    private Vector3 iniScaleLetterOne, iniScaleLetterTwo, iniScaleLetterThree, iniScaleLetterFour, iniScaleLetterFive, iniScaleLetterSix, iniScaleLetterSeven, iniScaleLetterEight, iniScaleLetterNine, iniScaleLetterTen, iniScaleLetterEleven;

    private bool oneCorrect, twoCorrect, threeCorrect, fourCorrect ,fiveCorrect, sixCorrect, sevenCorrect, eightCorrect, nineCorrect = false;
    
	public Animator animGood, animWrong;
    private string str = "";
    public string word;
	private int Sorter;
	public GameObject Pregunta1, Pregunta2, Pregunta3, Pregunta4, Pregunta5, Pregunta6, Pregunta7, ButtonPrev, Menu, Minigames;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;
    public AudioClip buttonDrop;
    public AudioClip reload;

    void Start()
    {   //Inicializa todos los vectores con su posicion actual
        LetterOneIni    = LetterOne.transform.position;
        LetterTwoIni    = LetterTwo.transform.position;
        LetterThreeIni  = LetterThree.transform.position;
        LetterFourIni    = LetterFour.transform.position;
        LetterFiveIni   = LetterFive.transform.position;
        LetterSixIni    = LetterSix.transform.position;
        LetterSevenIni  = LetterSeven.transform.position;
        LetterEightIni  = LetterEight.transform.position;
		LetterNineIni    = LetterNine.transform.position;
		LetterTenIni    = LetterTen.transform.position;
		LetterElevenIni  = LetterEleven.transform.position;

        iniScaleLetterOne    = LetterOne.transform.localScale;
        iniScaleLetterTwo    = LetterTwo.transform.localScale;
        iniScaleLetterThree  = LetterThree.transform.localScale;
        iniScaleLetterFour    = LetterFour.transform.localScale;
        iniScaleLetterFive   = LetterFive.transform.localScale;
        iniScaleLetterSix    = LetterSix.transform.localScale;
        iniScaleLetterSeven  = LetterSeven.transform.localScale;
        iniScaleLetterEight  = LetterEight.transform.localScale;
		iniScaleLetterNine  = LetterNine.transform.localScale;
		iniScaleLetterTen  = LetterTen.transform.localScale;
		iniScaleLetterEleven  = LetterEleven.transform.localScale;
    }

    // Controla el "Dragging" de las letras
    public void DragLetterOne()
    {
        LetterOne.transform.position = Input.mousePosition;
    }
    public void DragLetterTwo()
    {
        LetterTwo.transform.position = Input.mousePosition;
    }
    public void DragLetterThree()
    {
        LetterThree.transform.position = Input.mousePosition;
    }
    public void DragLetterFour()
    {
        LetterFour.transform.position = Input.mousePosition;
    }
    public void DragLetterFive()
    {
        LetterFive.transform.position = Input.mousePosition;
    }
    public void DragLetterSix()
    {
        LetterSix.transform.position = Input.mousePosition;
    }
    public void DragLetterSeven()
    {
        LetterSeven.transform.position = Input.mousePosition;
    }
    public void DragLetterEight()
    {
        LetterEight.transform.position = Input.mousePosition;
    }
    public void DragLetterNine()
    {
        LetterNine.transform.position = Input.mousePosition;
    }
    public void DragLetterTen()
    {
        LetterTen.transform.position = Input.mousePosition;
    }
    public void DragLetterEleven()
    {
        LetterEleven.transform.position = Input.mousePosition;
    }
   

    // Controla el "Dropping" de todas las letras
    public void DropLetterOne()
    {
        float Distance = Vector3.Distance(LetterOne.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterOne.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterOne.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterOne.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterOne.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterOne.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterOne.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterOne.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterOne.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterOne.transform.localScale = BoxOne.transform.localScale;
            LetterOne.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance2<50 && twoCorrect==false){
            LetterOne.transform.localScale = BoxTwo.transform.localScale;
            LetterOne.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterOne.transform.localScale = BoxThree.transform.localScale;
            LetterOne.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterOne.transform.localScale = BoxFour.transform.localScale;
            LetterOne.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterOne.transform.localScale = BoxFive.transform.localScale;
            LetterOne.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterOne.transform.localScale = BoxSix.transform.localScale;
            LetterOne.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterOne.transform.localScale = BoxSeven.transform.localScale;
            LetterOne.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        }  else if(Distance8<50 && eightCorrect==false){
            LetterOne.transform.localScale = BoxEight.transform.localScale;
            LetterOne.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterOne.transform.localScale = BoxNine.transform.localScale;
            LetterOne.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterOne.name;
            source.clip = buttonDrop;
            source.Play();
        } 
    }

    public void DropLetterTwo(){
        float Distance = Vector3.Distance(LetterTwo.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterTwo.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterTwo.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterTwo.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterTwo.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterTwo.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterTwo.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterTwo.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterTwo.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterTwo.transform.localScale = BoxOne.transform.localScale;
            LetterTwo.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterTwo.transform.localScale = BoxTwo.transform.localScale;
            LetterTwo.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterTwo.transform.localScale = BoxThree.transform.localScale;
            LetterTwo.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterTwo.transform.localScale = BoxFour.transform.localScale;
            LetterTwo.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterTwo.transform.localScale = BoxFive.transform.localScale;
            LetterTwo.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterTwo.transform.localScale = BoxSix.transform.localScale;
            LetterTwo.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterTwo.transform.localScale = BoxSeven.transform.localScale;
            LetterTwo.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterTwo.transform.localScale = BoxEight.transform.localScale;
            LetterTwo.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterTwo.transform.localScale = BoxNine.transform.localScale;
            LetterTwo.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        } 
    }

    public void DropLetterThree(){
        float Distance = Vector3.Distance(LetterThree.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterThree.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterThree.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterThree.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterThree.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterThree.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterThree.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterThree.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterThree.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterThree.transform.localScale = BoxOne.transform.localScale;
            LetterThree.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterThree.transform.localScale = BoxTwo.transform.localScale;
            LetterThree.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterThree.transform.localScale = BoxThree.transform.localScale;
            LetterThree.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterThree.transform.localScale = BoxFour.transform.localScale;
            LetterThree.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterThree.transform.localScale = BoxFive.transform.localScale;
            LetterThree.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterThree.transform.localScale = BoxSix.transform.localScale;
            LetterThree.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterThree.transform.localScale = BoxSeven.transform.localScale;
            LetterThree.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterThree.transform.localScale = BoxEight.transform.localScale;
            LetterThree.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterThree.transform.localScale = BoxNine.transform.localScale;
            LetterThree.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterThree.name;
            source.clip = buttonDrop;
            source.Play();
        } 
    }

    public void DropLetterFour(){
        float Distance = Vector3.Distance(LetterFour.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterFour.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterFour.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterFour.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterFour.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterFour.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterFour.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterFour.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterFour.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterFour.transform.localScale = BoxOne.transform.localScale;
            LetterFour.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterFour.transform.localScale = BoxTwo.transform.localScale;
            LetterFour.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterFour.transform.localScale = BoxThree.transform.localScale;
            LetterFour.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterFour.transform.localScale = BoxFour.transform.localScale;
            LetterFour.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterFour.transform.localScale = BoxFive.transform.localScale;
            LetterFour.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterFour.transform.localScale = BoxSix.transform.localScale;
            LetterFour.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterFour.transform.localScale = BoxSeven.transform.localScale;
            LetterFour.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterFour.transform.localScale = BoxEight.transform.localScale;
            LetterFour.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterFour.transform.localScale = BoxNine.transform.localScale;
            LetterFour.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterFour.name;
            source.clip = buttonDrop;
            source.Play();
        } 
    }

    public void DropLetterFive(){
        float Distance = Vector3.Distance(LetterFive.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterFive.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterFive.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterFive.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterFive.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterFive.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterFive.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterFive.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterFive.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterFive.transform.localScale = BoxOne.transform.localScale;
            LetterFive.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterFive.transform.localScale = BoxTwo.transform.localScale;
            LetterFive.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterFive.transform.localScale = BoxThree.transform.localScale;
            LetterFive.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterFive.transform.localScale = BoxFour.transform.localScale;
            LetterFive.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterFive.transform.localScale = BoxFive.transform.localScale;
            LetterFive.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterFive.transform.localScale = BoxSix.transform.localScale;
            LetterFive.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterFive.transform.localScale = BoxSeven.transform.localScale;
            LetterFive.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterFive.transform.localScale = BoxEight.transform.localScale;
            LetterFive.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterFive.transform.localScale = BoxNine.transform.localScale;
            LetterFive.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterFive.name;
            source.clip = buttonDrop;
            source.Play();
        } 
    }

    public void DropLetterSix(){
        float Distance = Vector3.Distance(LetterSix.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterSix.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterSix.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterSix.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterSix.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterSix.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterSix.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterSix.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterSix.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterSix.transform.localScale = BoxOne.transform.localScale;
            LetterSix.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterSix.transform.localScale = BoxTwo.transform.localScale;
            LetterSix.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterSix.transform.localScale = BoxThree.transform.localScale;
            LetterSix.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterSix.transform.localScale = BoxFour.transform.localScale;
            LetterSix.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterSix.transform.localScale = BoxFive.transform.localScale;
            LetterSix.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterSix.transform.localScale = BoxSix.transform.localScale;
            LetterSix.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterSix.transform.localScale = BoxSeven.transform.localScale;
            LetterSix.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterSix.transform.localScale = BoxEight.transform.localScale;
            LetterSix.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterSix.transform.localScale = BoxNine.transform.localScale;
            LetterSix.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterSix.name;
            source.clip = buttonDrop;
            source.Play();
        } 
    }

    public void DropLetterSeven(){
        float Distance = Vector3.Distance(LetterSeven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterSeven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterSeven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterSeven.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterSeven.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterSeven.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterSeven.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterSeven.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterSeven.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterSeven.transform.localScale = BoxOne.transform.localScale;
            LetterSeven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterSeven.transform.localScale = BoxTwo.transform.localScale;
            LetterSeven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterSeven.transform.localScale = BoxThree.transform.localScale;
            LetterSeven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterSeven.transform.localScale = BoxFour.transform.localScale;
            LetterSeven.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterSeven.transform.localScale = BoxFive.transform.localScale;
            LetterSeven.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterSeven.transform.localScale = BoxSix.transform.localScale;
            LetterSeven.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterSeven.transform.localScale = BoxSeven.transform.localScale;
            LetterSeven.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterSeven.transform.localScale = BoxEight.transform.localScale;
            LetterSeven.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterSeven.transform.localScale = BoxNine.transform.localScale;
            LetterSeven.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
    }

    public void DropLetterEight(){
        float Distance = Vector3.Distance(LetterEight.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterEight.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterEight.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterEight.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterEight.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterEight.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterEight.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterEight.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterEight.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterEight.transform.localScale = BoxOne.transform.localScale;
            LetterEight.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterEight.transform.localScale = BoxTwo.transform.localScale;
            LetterEight.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterEight.transform.localScale = BoxThree.transform.localScale;
            LetterEight.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterEight.transform.localScale = BoxFour.transform.localScale;
            LetterEight.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterEight.transform.localScale = BoxFive.transform.localScale;
            LetterEight.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterEight.transform.localScale = BoxSix.transform.localScale;
            LetterEight.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterEight.transform.localScale = BoxSeven.transform.localScale;
            LetterEight.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterEight.transform.localScale = BoxEight.transform.localScale;
            LetterEight.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterEight.transform.localScale = BoxNine.transform.localScale;
            LetterEight.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterEight.name;
            source.clip = buttonDrop;
            source.Play();
        } 
    }

    public void DropLetterNine(){
        float Distance = Vector3.Distance(LetterNine.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterNine.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterNine.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterNine.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterNine.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterNine.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterNine.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterNine.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterNine.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterNine.transform.localScale = BoxOne.transform.localScale;
            LetterNine.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterNine.transform.localScale = BoxTwo.transform.localScale;
            LetterNine.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterNine.transform.localScale = BoxThree.transform.localScale;
            LetterNine.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterNine.transform.localScale = BoxFour.transform.localScale;
            LetterNine.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterNine.transform.localScale = BoxFive.transform.localScale;
            LetterNine.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterNine.transform.localScale = BoxSix.transform.localScale;
            LetterNine.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterNine.transform.localScale = BoxSeven.transform.localScale;
            LetterNine.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterNine.transform.localScale = BoxEight.transform.localScale;
            LetterNine.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterNine.transform.localScale = BoxNine.transform.localScale;
            LetterNine.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterNine.name;
            source.clip = buttonDrop;
            source.Play();
        }
    }

    public void DropLetterTen(){
        float Distance = Vector3.Distance(LetterTen.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterTen.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterTen.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterTen.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterTen.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterTen.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterTen.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterTen.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterTen.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterTen.transform.localScale = BoxOne.transform.localScale;
            LetterTen.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterTen.transform.localScale = BoxTwo.transform.localScale;
            LetterTen.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterTen.transform.localScale = BoxThree.transform.localScale;
            LetterTen.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterTen.transform.localScale = BoxFour.transform.localScale;
            LetterTen.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterTen.transform.localScale = BoxFive.transform.localScale;
            LetterTen.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterTen.transform.localScale = BoxSix.transform.localScale;
            LetterTen.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterTen.transform.localScale = BoxSeven.transform.localScale;
            LetterTen.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterTen.transform.localScale = BoxEight.transform.localScale;
            LetterTen.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterTen.transform.localScale = BoxNine.transform.localScale;
            LetterTen.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterTen.name;
            source.clip = buttonDrop;
            source.Play();
        }
    }

    public void DropLetterEleven(){
        float Distance = Vector3.Distance(LetterEleven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(LetterEleven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(LetterEleven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(LetterEleven.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(LetterEleven.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(LetterEleven.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(LetterEleven.transform.position, BoxSeven.transform.position);
        float Distance8 = Vector3.Distance(LetterEleven.transform.position, BoxEight.transform.position);
        float Distance9 = Vector3.Distance(LetterEleven.transform.position, BoxNine.transform.position);

        if (Distance<50 && oneCorrect==false){
            LetterEleven.transform.localScale = BoxOne.transform.localScale;
            LetterEleven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance2<50 && twoCorrect==false){
            LetterEleven.transform.localScale = BoxTwo.transform.localScale;
            LetterEleven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance3 < 50 && threeCorrect==false){
            LetterEleven.transform.localScale = BoxThree.transform.localScale;
            LetterEleven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance4 < 50 && fourCorrect==false){
            LetterEleven.transform.localScale = BoxFour.transform.localScale;
            LetterEleven.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if (Distance5 < 50 && fiveCorrect == false){
            LetterEleven.transform.localScale = BoxFive.transform.localScale;
            LetterEleven.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance6<50 && sixCorrect==false){
            LetterEleven.transform.localScale = BoxSix.transform.localScale;
            LetterEleven.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance7<50 && sevenCorrect==false){
            LetterEleven.transform.localScale = BoxSeven.transform.localScale;
            LetterEleven.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance8<50 && eightCorrect==false){
            LetterEleven.transform.localScale = BoxEight.transform.localScale;
            LetterEleven.transform.position = BoxEight.transform.position;
            eightCorrect = true;
            BoxEight.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        } else if(Distance9<50 && nineCorrect==false){
            LetterEleven.transform.localScale = BoxNine.transform.localScale;
            LetterEleven.transform.position = BoxNine.transform.position;
            nineCorrect = true;
            BoxNine.name = LetterEleven.name;
            source.clip = buttonDrop;
            source.Play();
        }
    }

    //Controla el boton de "Enter" y revisa si la respuesta es correcta
    public void Check()
    {   
        // Concatena las letras en una palabra y las compara con una palabra asignada
		str = BoxOne.name + BoxTwo.name + BoxThree.name + BoxFour.name + BoxFive.name + BoxSix.name + BoxSeven.name 
			+ BoxEight.name + BoxNine.name;
		if(str == word)
        {
            source.clip = correct;
            source.Play();
			animGood.Play("CorrectoAnimation");
           	StartCoroutine(LoadNextPanel());            
        }
        else
        {
            source.clip = incorrect;
            source.Play();
			animWrong.Play ("WrongAnimation");
			pdf.SetActive (true);
        }
    }

    //Resetea todos los campos
    public void Reload()
    {
        str = "";
        oneCorrect = false;
        twoCorrect = false;
        threeCorrect = false;
        fourCorrect  = false;
        fiveCorrect = false;
        sixCorrect = false;
        sevenCorrect = false;
        eightCorrect  = false;
        nineCorrect = false;
        BoxOne.name ="1";
        BoxTwo.name = "2";
        BoxThree.name ="3";
        BoxFour.name = "4";
        BoxFive.name="5";
        BoxSix.name ="6";
        BoxSeven.name = "7";
        BoxEight.name ="8";
        BoxNine.name = "9";
        LetterOne.transform.position = LetterOneIni;
        LetterTwo.transform.position = LetterTwoIni;
        LetterThree.transform.position = LetterThreeIni;
        LetterFour.transform.position = LetterFourIni;
        LetterFive.transform.position = LetterFiveIni;
        LetterSix.transform.position = LetterSixIni;
        LetterSeven.transform.position = LetterSevenIni;
        LetterEight.transform.position = LetterEightIni;
        LetterNine.transform.position = LetterNineIni;
        LetterTen.transform.position = LetterTenIni;
        LetterEleven.transform.position = LetterElevenIni;
        LetterOne.transform.localScale = iniScaleLetterOne;
        LetterTwo.transform.localScale = iniScaleLetterTwo;
        LetterThree.transform.localScale = iniScaleLetterThree;
        LetterFour.transform.localScale = iniScaleLetterFour;
        LetterFive.transform.localScale = iniScaleLetterFive;
        LetterSix.transform.localScale = iniScaleLetterSix;
        LetterSeven.transform.localScale = iniScaleLetterSeven;
        LetterEight.transform.localScale = iniScaleLetterEight;
        LetterNine.transform.localScale = iniScaleLetterNine;
        LetterTen.transform.localScale = iniScaleLetterTen;
        LetterEleven.transform.localScale = iniScaleLetterEleven;
    }

	//Resetea las actividades para regresar al Menu
	public void ResetEverything(){
		Reload ();
		Pregunta1.SetActive (false);
		Pregunta2.SetActive (false);
		Pregunta3.SetActive (false);
		Pregunta4.SetActive (false);
		Pregunta5.SetActive (false);
		Pregunta6.SetActive (false);
		Pregunta7.SetActive (false);
		Minigames.SetActive (false);
		Menu.SetActive (true);
	}

    //Carga la siguiente Pregunta
    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(6f);
		questionToHide.SetActive(false);
		questionToShow.SetActive(true);
		Reload ();
    }

    //Controla el boton volver de las preguntas
	public void Volver()
    {
		backpanel.SetActive (true);
		questionToHide.SetActive (false);
		ButtonPrev.SetActive (true);
		Reload ();
	}

    //Selecciona una Pregunta de forma aleatoria para iniciar
	public void SorterInicio ()
    {
		Reload ();
		Sorter = (int)Random.Range (1f, 8f);
		ButtonPrev.SetActive (false);
		backpanel.SetActive (false);
		if (Sorter == 1) {
			Pregunta1.SetActive (true);
		} else if (Sorter == 2) {
			Pregunta2.SetActive (true);
		} else if (Sorter == 3) {
			Pregunta3.SetActive (true);
		} else if (Sorter == 4) {
			Pregunta4.SetActive (true);
		} else if (Sorter == 5) {
			Pregunta5.SetActive (true);
		} else if (Sorter == 6) {
			Pregunta6.SetActive (true);
		} else if (Sorter == 7) {
			Pregunta7.SetActive (true);
		}
	}

}
