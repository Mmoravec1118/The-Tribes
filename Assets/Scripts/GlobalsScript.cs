﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GlobalsScript : MonoBehaviour {

    #region Enumerations

    // Tribe type enumeration
    public enum TribeType
    { Warrior, Bandit, Nomad, Peaceful }

    // Card Types
    public enum CardType { Event, GlobalEvent, Scar }

    // All player Stats
    public enum Traits { Strength, Agility, Trust, Survival, Notoriety }

    // All Resources
    public enum Resources { Wood, Stone, People, Food }

    // Areas
    public enum Areas {Mountain, Plain, Swamp, Desert, Forest }

    #endregion

    #region Fields
    static int numPlayers = 0;                                         // number of players in game
    int currPlayerCount = 0;
    int currPlayerTurn = 0;
    List<PlayerClass> players;

    //static GlobalsScript instance;

    #endregion

    #region Constants

    public const int statMax = 16;

    #endregion

    #region Singleton

    // returns instance of object or creates it if it is missing
    //public static GlobalsScript Instance
    //{
    //    get { return instance ?? (instance = new GlobalsScript()); }
    //}

    // keep object in scene
    void Start()
    {
        players = new List<PlayerClass>();    // list of players with stats and such
       // deck = new Deck();
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            Ending();
        }
    }

    #endregion

    #region Properties

    public static int NumberofPlayers
    {
        get
        {
            return numPlayers;
        }
        set
        {
            numPlayers = value;
        }
    }

    public List<PlayerClass> Players
    {
        get
        {
            return players;
        }
    }

    public int CurrentPlayerCount
    {
        get { return currPlayerCount; }
    }

    public int PlayerTurn
    {
        get
        {
            return currPlayerTurn;
        }
        set
        {
            currPlayerTurn = value;
            if (currPlayerTurn > numPlayers - 1)
            {
                currPlayerTurn = 0;
            }
        }
    }

    public List<PlayerClass> GetPlayerList()
    {
        return players;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Returns current player or
    /// Returns player at selected position.
    /// If position doesn't exist, returns null
    /// </summary>
    /// <param name="playerNum"></param>
    /// <returns></returns>
    public PlayerClass GetPlayer()
    {
        return players[currPlayerTurn];
    }

    // returns player at given number from list
    public PlayerClass GetPlayer(int number)
    {
        if (number < numPlayers)
        {
            return players[number];
        }
        else
        {
            Debug.Log("Number entered is out of range");
            return null;
        }
        
    }

    // adds playerclass to list
    public void AddPlayer(PlayerClass newPlayer)
    {
        players.Add(newPlayer);
        currPlayerCount++;
    }


    public void Ending()
    {
        SceneManager.LoadScene("EndingScene");
    }

    #endregion

}
