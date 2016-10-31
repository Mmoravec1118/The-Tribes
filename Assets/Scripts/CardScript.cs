using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CardScript : MonoBehaviour {

    public class EventCard
    {
        private string cardTitle;
        private string cardDescription;
        private Choice[] choices;

        //choices are brought in from the file.  Object type Choice is currently not constructed yet.  requires another script.
        public EventCard(string cardTitle, string cardDescription, Choice[] choices)
        {
            this.cardDescription = cardDescription;
            this.cardTitle = cardTitle;
            this.choices = choices
        }

        //public Choice choices;

        //initializes the card
        void Start()
        {
            //initialize variables to the card.

            //cardTitle = title of the card from the text file.  currently Hardcoded.
            //tribeName = the current tribe the player who deals the card is using.
            //cardDescription = the flavortext on the card with the choices.


            cardTitle.text = "Severe Drought";
            cardDescription.text = "Severe Drought has befallen the land.  Water Dries up far quicker, plants are dying, and your tribes people are struggling in the blazing heat";
            //choices = ;//load in list of choices. here in which to display on the bottom of the screen.





        }

        //deals the card to the field
        void DealCard()
        {
            //deal the card to the field with the given pieces on the card

            //draw title and text to locations on the card.
            //place choices on the screen as text objects.
            //space placement of text choices on buttons
        }

        //applies the card effect based on the season passed into the card, which modifies the applied effect
        void ApplyCardEffect()
        {
            //on choice selection, enact the choice parameters to the player stats.
            //these parameters should be placed in the choice object on that card, so that on clicking it, the game does not
            //care what the choice was, only that it was selected and it applied the parameters on the card.

            //post the message that corresponds with the choice in the file.

            //if the choice causes the token to move, make the token object associated with the tribe enum to move to a new designated coordinate on the map.
        }


        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Choice
    {
        string description;
        
        //EFFECTS?

    }

}

