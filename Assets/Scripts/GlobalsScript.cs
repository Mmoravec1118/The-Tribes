﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalsScript : MonoBehaviour {

    #region Enumerations

    // Tribe type enumeration
    public enum TribeType
    { Barbarian, PeaceMaker, Nomad, Farmer, Gaility }

    // Card Types
    public enum CardType { Event, GlobalEvent, Scar }

    // All player Stats
    public enum Traits { Strength, Agility, Trust, Survival, Notoriety }

    // All Resources
    public enum Resources { Wood, Stone, People, Food }

    // Areas
    public enum Areas {Mountain, Plain, Swamp, Desert }

    #endregion

    #region Fields

    int numPlayers;                                         // number of players in game
    List<PlayerClass> players = new List<PlayerClass>();    // list of players with stats and such

    static GlobalsScript instance;

    #endregion

    #region Singleton

    // returns instance of object or creates it if it is missing
    public static GlobalsScript Instance
    {
        get { return instance ?? (instance = new GlobalsScript()); }
    }

    // keep object in scene
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    #endregion

    #region Properties

    public int NumberofPlayers
    {
        get
        {
            return numPlayers;
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Returns player at selected position.
    /// If position doesn't exist, returns null
    /// </summary>
    /// <param name="playerNum"></param>
    /// <returns></returns>
    public PlayerClass GetPlayer(int playerNum)
    {
        if (playerNum < players.Count)
        {
            return players[playerNum];
        }
        else
        {
            Debug.Log("Out of Range, not that many players");
            return null;
        }
    }

    public void AddPlayer(PlayerClass newPlayer)
    {
        players.Add(newPlayer);
        numPlayers++;
    }


    #endregion

}
