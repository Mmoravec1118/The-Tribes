using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerClass : MonoBehaviour {

    #region Fields

    // Tribe type enumeration
    public enum TribeType
    { Barbarian, PeaceMaker, Nomad, Farmer, Gaility }

    // dictionaries for stats and resources
    Dictionary<Card.Traits, int> statDictionary = new Dictionary<Card.Traits, int>();
    Dictionary<Card.Resources, int> resourceDictionary = new Dictionary<Card.Resources, int>();

    // victory point counter
    int victoryPoint = 0;

    // tribe name
    string name;

    //Tribe type
    //TribeType tribeType;

    #endregion

    #region Start

    // Use this for initialization
    void Start () {

        // initialize stat dictionary
        statDictionary[Card.Traits.Strength] = 0;
        statDictionary[Card.Traits.Agility] = 0;
        statDictionary[Card.Traits.Trust] = 0;
        statDictionary[Card.Traits.Notoriety] = 0;
        statDictionary[Card.Traits.Survival] = 0;

        // initialize resource dictionary
        resourceDictionary[Card.Resources.Food] = 0;
        resourceDictionary[Card.Resources.People] = 0;
        resourceDictionary[Card.Resources.Stone] = 0;
        resourceDictionary[Card.Resources.Wood] = 0;

    }

    #endregion

    #region Properties

    #region Stats
    public int Strength
    {
        get
        {
            return statDictionary[Card.Traits.Strength];
        }
        set
        {
            statDictionary[Card.Traits.Strength] = value;
        }
    }

    public int Agility
    {
        get
        {
            return statDictionary[Card.Traits.Agility];
        }
        set
        {
            statDictionary[Card.Traits.Agility] = value;
        }
    }
    public int Survivability
    {
        get
        {
            return statDictionary[Card.Traits.Survival];
        }
        set
        {
            statDictionary[Card.Traits.Survival] = value;
        }
    }

    public int Trust
    {
        get
        {
            return statDictionary[Card.Traits.Trust];
        }
        set
        {
            statDictionary[Card.Traits.Trust] = value;
        }
    }

    public int Notoriety
    {
        get
        {
            return statDictionary[Card.Traits.Notoriety];
        }
        set
        {
            statDictionary[Card.Traits.Notoriety] = value;
        }
    }

    #endregion

    #region Resources
    public int Wood
    {
        get
        {
            return resourceDictionary[Card.Resources.Wood];
        }
        set
        {
            resourceDictionary[Card.Resources.Wood] = value;
        }
    }
    public int Food
    {
        get
        {
            return resourceDictionary[Card.Resources.Food];
        }
        set
        {
            resourceDictionary[Card.Resources.Food] = value;
        }
    }
    public int Stone
    {
        get
        {
            return resourceDictionary[Card.Resources.Stone];
        }
        set
        {
            resourceDictionary[Card.Resources.Stone] = value;
        }
    }
    public int People
    {
        get
        {
            return resourceDictionary[Card.Resources.People];
        }
        set
        {
            resourceDictionary[Card.Resources.People] = value;
        }
    }
    #endregion

    #region Other

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    // get or set victory points
    public int VictoryPoints
    {
        get
        {
            return victoryPoint;
        }
        set
        {
            victoryPoint = value;
        }
    }


    #endregion

    #endregion
}
