using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DisplayPlayerInfo : MonoBehaviour {

    // text box for displaying player info
    Text playerDisplay;

    // current player turn
    int currTurn = 0;

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
             + "Victory Points:" + currplayer.VictoryPoints + "\n"
             + "Area Effects:";
        switch (currplayer.Area)
        {
            case GlobalsScript.Areas.Plain:
                {
                    playerDisplay.text += "\n"  + "Fields improve your agricultural capabilities. when you harvest food, +3 food";
                    break;
                }
            case GlobalsScript.Areas.Mountain:
                {
                    playerDisplay.text += "\n" + "Mountains, If you collect stone +2 to stone +1 str";
                    break;
                }
            case GlobalsScript.Areas.Forest:
                {
                    playerDisplay.text += "\n" + "Forest gives you +3 wood when collecting wood";
                    break;
                }
            case GlobalsScript.Areas.Desert:
                {
                    playerDisplay.text += "\n" + "The Desert tests your skills. Raise SR +2";
                    break;
                }
            case GlobalsScript.Areas.Swamp:
                {
                    playerDisplay.text += "\n" + "The Swamp improve your tribes agility +1 and food +2 when harvesting";
                    break;
                }
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

            // Loops current turn back to 0 if if exceeds the list capacity
            if (currTurn >= GlobalsScript.NumberofPlayers)
            {
                currTurn = 0;
            }

            // Updates the displayed text to current player info
            //DisplayText(currTurn);
        }
    }

    #endregion


}
