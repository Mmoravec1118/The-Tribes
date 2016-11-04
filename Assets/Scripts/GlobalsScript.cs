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

    #endregion

    int numPlayers;                                         // number of players in game
    List<PlayerClass> players = new List<PlayerClass>();    // list of players with stats and such

}
