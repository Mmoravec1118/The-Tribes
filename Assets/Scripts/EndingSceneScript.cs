using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class EndingSceneScript : MonoBehaviour {

    // globals script and players
    GlobalsScript globals;
    PlayerClass[] players;

    // text fields
    [SerializeField] Text displayText0;

    // ending canvas
    [SerializeField] Canvas ending;

    // surrent player display
    int currPlayer = 0;

    // Use this for initialization
    void Start () {

        // save references to fields
        globals = FindObjectOfType<GlobalsScript>();
        players = new PlayerClass[globals.CurrentPlayerCount];

        for (int i = 0; i < globals.CurrentPlayerCount; ++i)
        {
            players[i] = globals.GetPlayer(i);
        }

        for (int i = 0; i < globals.CurrentPlayerCount; ++i)
        {
            if (players[i] != null)
            {
                players[i].VictoryPoints = i;
            }
        }

        // sort players by victory points
        players = players.OrderByDescending(go => go.VictoryPoints).ToArray();

    }
	
	// Update is called once per frame
	void Update () {

        ChangePlayer(currPlayer);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currPlayer < globals.CurrentPlayerCount - 1)
            {
                currPlayer++;
            }
        else
            {
                ending.enabled = true;
                enabled = false;
                //DisplayEnd();
            }
        }
	}

    void ChangePlayer(int i)
    {
        // check if player exists
        if (players[i] != null)
        {
            
            // display player info
            displayText0.text = "Tribe Name: " + players[i].Name + "\n"
             + "Player Stats:" + "\n"
             + "  Strength:  " + players[i].Strength + "\n"
             + "  Agility:   " + players[i].Agility + "\n"
             + "  Trust:     " + players[i].Trust + "\n"
             + "  Survival:  " + players[i].Survival + "\n"
             + "  Notoriety: " + players[i].Notoriety + "\n"
             + "Resources:" + "\n"
             + "  Wood:   " + players[i].Wood + "\n"
             + "  Stone:  " + players[i].Stone + "\n"
             + "  Food:   " + players[i].Food + "\n"
             + "  People: " + players[i].People + "\n"
             + "Victory Points:" + players[i].VictoryPoints;
        }
    }

    void DisplayEnd()
    {
        ending.enabled = true;
        enabled = false;
    }

}
