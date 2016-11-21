using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class EndingSceneScript : MonoBehaviour {

    // globals script and players
    GlobalsScript globals;
    PlayerClass[] players = new PlayerClass[4];

    // text fields
    [SerializeField] Text displayText0;
    [SerializeField] Text displayText1;
    [SerializeField] Text displayText2;
    [SerializeField] Text displayText3;

    // ending canvas
    [SerializeField] Canvas ending;

    // array of text componants
    Text[] displays = new Text[4];

    // surrent player display
    int currPlayer = 0;

    // Use this for initialization
    void Start () {

        // save references to fields
        globals = FindObjectOfType<GlobalsScript>();
        players[0] = globals.GetPlayer(0);
        players[1] = globals.GetPlayer(1);
        players[2] = globals.GetPlayer(2);
        players[3] = globals.GetPlayer(3);

        for (int i = 0; i < 4; ++i)
        {
            if (players[i] != null)
            {
                players[i].VictoryPoints = i;
            }
        }

        // sort players by victory points
        players = players.OrderBy(go => go.VictoryPoints).ToArray();

        // save text componants to array
        displays[0] = displayText0;
        displays[1] = displayText1;
        displays[2] = displayText2;
        displays[3] = displayText3;
    }
	
	// Update is called once per frame
	void Update () {

        ChangePlayer(currPlayer);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currPlayer < 4)
            {
                displays[currPlayer].enabled = false;
                currPlayer++;
            }
            else if (currPlayer >= 4)
            {

            }
        }
	}

    void ChangePlayer(int i)
    {
        // check if player exists
        if (players[i] != null)
        {
            displays[i].enabled = true;
            // display player info
            displays[i].text = "Tribe Name: " + players[i].Name + "\n"
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
    }

}
