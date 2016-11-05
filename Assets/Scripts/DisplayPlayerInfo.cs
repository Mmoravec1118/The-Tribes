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
    int currTurn = 1;

    // previouse players turn
    // starts at zero for easier initialization
    int prevTurn = 0;

	// Use this for initialization
	void Start () {

        playerDisplay = GetComponent<Text>();
        for (int i = 0; i < GlobalsScript.Instance.NumberofPlayers; i++)
        {
            players.Add(GlobalsScript.Instance.GetPlayer(i));
        }
	
	}
	
	// Update is called once per frame
	void Update () {

        if (currTurn != prevTurn)
        {
            DisplayText(currTurn - 1);
            prevTurn = currTurn;
            currTurn++;
        }
        if (currTurn > GlobalsScript.Instance.NumberofPlayers)
        {
            currTurn = 1;
            prevTurn = 0;
        }
	
	}

    #region Methods

    void DisplayText(int playerTurn)
    {
        playerDisplay.text = "Tribe Name: " + players[playerTurn].name
            + "Player Stats:" + "Strength: " + players[playerTurn].Strength
            + "Agility: " + players[playerTurn].Agility
            + "Trust: " + players[playerTurn].Trust
            +"Survival: " + players[playerTurn].Survivability
            +"Notoriety: " + players[playerTurn].Notoriety;
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
        }
    }



    #endregion


}
