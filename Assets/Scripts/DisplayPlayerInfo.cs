using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DisplayPlayerInfo : MonoBehaviour {

    // text box for displaying player info
    Text playerDisplay;

    // current player turn
    int currTurn = 1;

    // saved reference to globals script
    GlobalsScript globals;

	// Use this for initialization
	void Start () {

        playerDisplay = GetComponent<Text>();
        globals = FindObjectOfType<GlobalsScript>();
	
	}
	
	// Update is called once per frame
	void Update () {

        DisplayText();

    }

    #region Methods

    public void DisplayText()
    {
        PlayerClass currplayer = globals.GetPlayer();
        playerDisplay.text = "Tribe Name: " + currplayer.Name + "\n"
             + "Player Stats:" + "\n"
             + "  Strength:  " + currplayer.Strength + "\n"
             + "  Agility:   " + currplayer.Agility + "\n"
             + "  Trust:     " + currplayer.Trust + "\n"
             + "  Survival:  " + currplayer.Survival + "\n"
             + "  Notoriety: " + currplayer.Notoriety + "\n"
             + "Resources:" + "\n"
             + "  Wood:   " + currplayer.Wood + "\n"
             + "  Stone:  " + currplayer.Stone + "\n"
             + "  Food:   " + currplayer.Food + "\n"
             + "  People: " + currplayer.People + "\n"
             + "Victory Points:" + currplayer.VictoryPoints;
    }

    public void DisplayToken()
    {
        switch(globals.GetPlayer().Area)
        {
            case GlobalsScript.Areas.Desert:

                break;

            case GlobalsScript.Areas.Forest:
                break;

            case GlobalsScript.Areas.Mountain:
                break;

            case GlobalsScript.Areas.Plain:
                break;

            case GlobalsScript.Areas.Swamp:
                break;

            default:
                break;
        }
    }

    #endregion


    #region Properties

    /// <summary>
    /// returns current player turn or adds value to player turn
    /// </summary>
    public int CurrentTurn
    {
        get
        {
            return currTurn;
        }
        set
        {
            currTurn += value;
        }
    }

    #endregion


}
