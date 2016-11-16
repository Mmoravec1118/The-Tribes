using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DisplayPlayerInfo : MonoBehaviour {

    // text box for displaying player info
    Text playerDisplay;

    // list of players playing
    //List<PlayerClass> players = new List<PlayerClass>();

    // current player turn
    int currTurn = 1;

    // previouse players turn
    // starts at zero for easier initialization
    //int prevTurn = 0;
    GlobalsScript globals;

	// Use this for initialization
	void Start () {

        playerDisplay = GetComponent<Text>();
        //for (int i = 0; i < GlobalsScript.NumberofPlayers; i++)
        //{
        //    players.Add(FindObjectOfType<GlobalsScript>().GetPlayer(i));
        //}
        //globals = FindObjectOfType<GlobalsScript>();
	
	}
	
	// Update is called once per frame
	void Update () {

        DisplayText();

    }

    #region Methods

    public void DisplayText()
    {
        PlayerClass currplayer = FindObjectOfType<GlobalsScript>().GetPlayer();
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
             + "  People: " + currplayer.People + "\n";
    }

    #endregion


    #region Properties

    /// <summary>
    /// Adds a new player to the list of current players
    /// </summary>
    //public PlayerClass Players
    //{
    //    set
    //    {
    //        players.Add(value);
    //    }
    //}

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
