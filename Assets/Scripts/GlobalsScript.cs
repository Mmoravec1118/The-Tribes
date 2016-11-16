using UnityEngine;
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
    static int numPlayers = 0;                                         // number of players in game
    int currPlayerCount = 0;
    int currPlayerTurn = 0;
    List<PlayerClass> players;
    Deck deck;

    static GlobalsScript instance;

    #endregion

    #region Constants

    public const int statMax = 16;

    #endregion

    #region Singleton

    // returns instance of object or creates it if it is missing
    public static GlobalsScript Instance
    {
        get { return instance ?? (instance = new GlobalsScript()); }
    }

    // keep object in scene
    void Start()
    {
        players = new List<PlayerClass>();    // list of players with stats and such
        deck = new Deck();
        DontDestroyOnLoad(this);
    }

    #endregion

    #region Properties

    public Deck PlayDeck
    {
        get
        {
            return deck;
        }
    }


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


    #endregion

}
