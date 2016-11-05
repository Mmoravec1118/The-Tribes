using UnityEngine;
using System.Collections;

public class CardHandlerScript : MonoBehaviour
{
    struct Card
    {
        string[] flavorText;
        
        struct Options
        {

        }

        struct Results
        {

        }
    }

    struct Deck
    {
        Card[] cards;

        public void Shuffle()
        {

        }

        public void Draw()
        {

        }

        public void Discard()
        {

        }

        Card[] hand;
        Card[] discard;
    }

    Deck deck;

    #region Initialization

    // Use this for initialization
	void Start () 
    {
	
	}

    #endregion

    #region Update

    // Update is called once per frame
	void Update () 
    {

    }

    #endregion
}
