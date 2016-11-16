using UnityEngine;
using System.Collections;

public class CardButtonsScript : MonoBehaviour {

    // card choice currently loaded into card
    CardChoice currCardChoice;


    [SerializeField] CardChoice choice1;
    [SerializeField] CardChoice choice2;
    [SerializeField] CardChoice choice3;

    



    bool win;

    int cost;
    GlobalsScript.Traits trait;

    void Start()
    {
        // get cardChoice
        currCardChoice = GetComponent<CardChoice>();


        // get die roller
        //die = FindObjectOfType<DieScript>().GetComponent<DieScript>();



    }

    
}
