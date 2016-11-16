using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DisplayPlayerInfo : MonoBehaviour {

    // text box for displaying player info
    Text playerDisplay;

    // list of players playing
    List<PlayerClass> players = new List<PlayerClass>();

    // current player turn
    int currTurn = 0;

    // COMMENTING OUT BECAUSE PREVTURN IS OVERLY CONVOLUTED
    // previouse players turn
    // starts at zero for easier initialization
    //int prevTurn = 0;

	// Use this for initialization
	void Start () {

        playerDisplay = GetComponent<Text>();
        //for (int i = 0; i < GlobalsScript.NumberofPlayers; i++)
        //{
        //    players.Add(GlobalsScript.Instance.GetPlayer(i));
        //}

        players = GlobalsScript.Instance.GetPlayerList();

        DisplayText(currTurn);
        for (int i = 0; i < GlobalsScript.NumberofPlayers; i++)
        {
            players.Add(FindObjectOfType<GlobalsScript>().GetPlayer(i));
        }
	
	}
	
	// Update is called once per frame
	void Update () {

        // COMMENTING OUT FOR EASIER IMPLEMENTATION
        /*
        if (currTurn != prevTurn)
        {
            DisplayText(currTurn - 1);
            prevTurn = currTurn;
            //currTurn++;
        }
        if (currTurn > GlobalsScript.NumberofPlayers)
        {
            currTurn = 1;
            prevTurn = 0;
        }
        */
	
	}

    #region Methods

    void DisplayText(int playerTurn)
    {
        playerDisplay.text = "Tribe Name: " + players[playerTurn].Name + "\n"
             + "Player Stats:" + "\n"
             + "  Strength:  " + players[playerTurn].Strength + "\n"
             + "  Agility:   " + players[playerTurn].Agility + "\n"
             + "  Trust:     " + players[playerTurn].Trust + "\n"
             + "  Survival:  " + players[playerTurn].Survival + "\n"
             + "  Notoriety: " + players[playerTurn].Notoriety + "\n"
             + "Resources:" + "\n"
             + "  Wood:   " + players[playerTurn].Wood + "\n"
             + "  Stone:  " + players[playerTurn].Stone + "\n"
             + "  Food:   " + players[playerTurn].Food + "\n"
             + "  People: " + players[playerTurn].People + "\n";
    }

    #endregion


    #region Properties

    /// <summary>
    /// Adds a new player to the list of current players
    /// </summary>
    public PlayerClass Players
    {
        set
        {
            players.Add(value);
        }
    }

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
            if (currTurn >= players.Count)
            {
                currTurn = 0;
            }

            // Updates the displayed text to current player info
            DisplayText(currTurn);
        }
    }



    #endregion


}
