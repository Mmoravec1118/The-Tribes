using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TokenManager : MonoBehaviour {

    #region Fields

    #region Serializable Fields

    [SerializeField]
    GameObject WarriorToken;
    [SerializeField]
    GameObject BanditToken;
    [SerializeField]
    GameObject NomadToken;
    [SerializeField]
    GameObject PeacefulToken;

    #endregion

    // token array
    List<GameObject> tokens = new List<GameObject>();

    #region Area Locations
    float desertX;
    float desertY;
    float forestX;
    float forestY;
    float plainX;
    float plainY;
    float mountainX;
    float mountainY;
    float swampX;
    float swampY;
    #endregion

    // screen size
    float screenX;
    float screenY;

    // offset sizes
    float xOffset;
    float yOffset;

    // Number of players
    int count;

    // saved reference to globals script
    GlobalsScript globals;

    #endregion


    // Use this for initialization
    void Start () {

        // save reference to globals script
        globals = FindObjectOfType<GlobalsScript>();
        // get number of players in this game
        count = globals.CurrentPlayerCount;

        //get screen size values for area locations
        screenX = Screen.width / 2f;
        screenY = Screen.height / 2f;

        // set initial area x and y values
        desertX = (float)(screenX * (2 / 3f));
        desertY = (float)(screenY * (1 / 8f));
        forestX = (float)(screenX * (1 / 4f));
        forestY = (float)(screenY * (2 / 3f));
        plainX = 0;
        plainY = 0;
        mountainX = (float)(screenX * (1 / 4f));
        mountainY = (float)(screenY * (1 / 8f));
        swampX = (float)(screenX * (1 / 4f));
        swampY = (float)(screenY * (1 / 3f));

        // set token offset
        xOffset = WarriorToken.GetComponent<SpriteRenderer>().bounds.max.x;
        yOffset = WarriorToken.GetComponent<SpriteRenderer>().bounds.max.y;

        // creat tokens and add them to list
        CreateTokens();
    }
	
	// Update is called once per frame
	void Update () {
        // move tokens to correct positions
        MoveTokens();
	}

    #region Methods

    /// <summary>
    /// Moves all tokens in play to appropriate locations based on player # and tribe area
    /// </summary>
    void MoveTokens()
    {
        for (int i = 0; i < count; ++i)
        {
            switch(globals.GetPlayer(i).Area)
            {
                // move token position based on area
                // desert area
                case GlobalsScript.Areas.Desert:
                    tokens[i].transform.position = new Vector3(desertX + (xOffset * i), desertY, 0);
                    break;
                    // forest area
                case GlobalsScript.Areas.Forest:
                    tokens[i].transform.position = new Vector3(forestX + (xOffset * i), forestY, 0);
                    break;
                    // mountain area
                case GlobalsScript.Areas.Mountain:
                    tokens[i].transform.position = new Vector3(mountainX + (xOffset * i), mountainY, 0);
                    break;
                    // swamp area
                case GlobalsScript.Areas.Swamp:
                    tokens[i].transform.position = new Vector3(swampX + (xOffset * i), swampY, 0);
                    break;
                    //plains area
                case GlobalsScript.Areas.Plain:
                    tokens[i].transform.position = new Vector3(plainX + (xOffset * i), plainY, 0);
                    break;
            }
        }
    }

    /// <summary>
    /// Creates tokesn for each player based on their tribe type and moves them to an area off screen
    /// </summary>
    void CreateTokens()
    {
        // iterate through all players
        for (int i = 0; i < count; ++i)
        {
            GameObject go;
            switch (globals.GetPlayer(i).TribeType)
            {
                // bandit tribe token
                case GlobalsScript.TribeType.Bandit:
                    go = Instantiate<GameObject>(BanditToken);
                    go.transform.position = new Vector3(10000, 10000, 0);
                    tokens.Add(go);
                    break;
                    //warrior tribe token
                case GlobalsScript.TribeType.Warrior:
                    go = Instantiate<GameObject>(WarriorToken);
                    go.transform.position = new Vector3(10000, 10000, 0);
                    tokens.Add(go);
                    break;
                    // peacful tribe token
                case GlobalsScript.TribeType.Peaceful:
                    go = Instantiate<GameObject>(PeacefulToken);
                    go.transform.position = new Vector3(10000, 10000, 0);
                    tokens.Add(go);
                    break;
                    // nomad tribe token
                case GlobalsScript.TribeType.Nomad:
                    go = Instantiate<GameObject>(NomadToken);
                    go.transform.position = new Vector3(10000, 10000, 0);
                    tokens.Add(go);
                    break;
            }

        }
    }

    #endregion

}
