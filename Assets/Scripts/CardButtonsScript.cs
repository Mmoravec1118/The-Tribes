using UnityEngine;
using System.Collections;

public class CardButtonsScript : MonoBehaviour {


    CardChoice currCardChoice;

    void Start()
    {
        currCardChoice = GetComponent<CardChoice>();
    }
	
    public void CardChoice1()
    {
        GlobalsScript.Traits trait = currCardChoice.GetTrait;
        int cost = currCardChoice.GetEffectCost;
    }

    public void CardChoice2()
    {

    }

    public void CardChoice3()
    {

    }
}
