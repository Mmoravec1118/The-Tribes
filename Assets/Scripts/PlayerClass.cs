using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerClass
{

    #region Fields

    #region Serializable Fields
    // serializable fields
    [SerializeField]
    Texture2D warriorToken;
    [SerializeField]
    Texture2D banditToken;
    [SerializeField]
    Texture2D agriculturToken;
    [SerializeField]
    Texture2D peacefulToken;
    [SerializeField]
    Texture2D nomadToken;
    #endregion

    // dictionaries for stats and resources
    Dictionary<GlobalsScript.Traits, int> statDictionary = new Dictionary<GlobalsScript.Traits, int>();
    Dictionary<GlobalsScript.Resources, int> resourceDictionary = new Dictionary<GlobalsScript.Resources, int>();


    // victory point counter
    int victoryPoint = 0;

    // tribe name
    string name = "";

    //Tribe type
    GlobalsScript.TribeType tribeType;

    // bool for tool creation
    bool hasTool = false;

    //Current area of tribe
    GlobalsScript.Areas currArea;

    #endregion

    #region Constructor

    public PlayerClass()
    {
        // Initializes all values to default
        ResetPlayerValues();

    }

    #endregion

    #region Properties

    #region Stats
    public int Strength
    {
        get
        {
            return statDictionary[GlobalsScript.Traits.Strength];
        }
        set
        {
            statDictionary[GlobalsScript.Traits.Strength] = value;
        }
    }

    public int Agility
    {
        get
        {
            return statDictionary[GlobalsScript.Traits.Agility];
        }
        set
        {
            statDictionary[GlobalsScript.Traits.Agility] = value;
        }
    }
    public int Survival
    {
        get
        {
            return statDictionary[GlobalsScript.Traits.Survival];
        }
        set
        {
            statDictionary[GlobalsScript.Traits.Survival] = value;
        }
    }

    public int Trust
    {
        get
        {
            return statDictionary[GlobalsScript.Traits.Trust];
        }
        set
        {
            statDictionary[GlobalsScript.Traits.Trust] = value;
        }
    }

    public int Notoriety
    {
        get
        {
            return statDictionary[GlobalsScript.Traits.Notoriety];
        }
        set
        {
            statDictionary[GlobalsScript.Traits.Notoriety] = value;
        }
    }

    #endregion

    #region Resources
    public int Wood
    {
        get
        {
            return resourceDictionary[GlobalsScript.Resources.Wood];
        }
        set
        {
            resourceDictionary[GlobalsScript.Resources.Wood] = value;
        }
    }
    public int Food
    {
        get
        {
            return resourceDictionary[GlobalsScript.Resources.Food];
        }
        set
        {
            resourceDictionary[GlobalsScript.Resources.Food] = value;
        }
    }
    public int Stone
    {
        get
        {
            return resourceDictionary[GlobalsScript.Resources.Stone];
        }
        set
        {
            resourceDictionary[GlobalsScript.Resources.Stone] = value;
        }
    }
    public int People
    {
        get
        {
            return resourceDictionary[GlobalsScript.Resources.People];
        }
        set
        {
            resourceDictionary[GlobalsScript.Resources.People] = value;
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

    public GlobalsScript.TribeType Tribe
    {
        get
        {
            return tribeType;
        }
        set
        {
            tribeType = value;
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

    public GlobalsScript.Areas Area
    {
        get
        {
            return currArea;
        }
        set
        {
            currArea = value;
        }
    }

    public bool HasTool
    {
        get
        {
            return hasTool;
        }
        set
        {
            hasTool = value;
        }
    }

    public GlobalsScript.TribeType TribeType
    { get
        {
            return tribeType;
        }
        set
        {
            tribeType = value;
        }
    }



    #endregion

    #endregion

    #region Public Methods

    public void ResetPlayerValues()
    {
        // initialize stat dictionary
        statDictionary[GlobalsScript.Traits.Strength] = 0;
        statDictionary[GlobalsScript.Traits.Agility] = 0;
        statDictionary[GlobalsScript.Traits.Trust] = 0;
        statDictionary[GlobalsScript.Traits.Notoriety] = 0;
        statDictionary[GlobalsScript.Traits.Survival] = 0;

        // initialize resource dictionary
        resourceDictionary[GlobalsScript.Resources.Food] = 4;
        resourceDictionary[GlobalsScript.Resources.People] = 4;
        resourceDictionary[GlobalsScript.Resources.Stone] = 4;
        resourceDictionary[GlobalsScript.Resources.Wood] = 4;

        currArea = GlobalsScript.Areas.Plain;

        name = "";
    }

    public void DisplayToken(int count, Rect spriteRect)
    {
        Sprite token;
        switch (tribeType)
        {
            case GlobalsScript.TribeType.Warrior:
                {
                    token = Sprite.Create(warriorToken, spriteRect, Vector2.zero);
                    break;
                }
        }
    }
        

    #endregion
}
