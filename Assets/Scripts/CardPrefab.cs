using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class CardPrefab : MonoBehaviour
    {
        #region Fields

        // References to card items
        [SerializeField]
        Text titleMesh;
        [SerializeField]
        public Text descriptionMesh;
        [SerializeField]
        Text option1;
        [SerializeField]
        Text option2;
        [SerializeField]
        Text option3;

        // The current card in play
        Card card;

        // Reference to the global script
        GlobalsScript globals;

        // Reference to the menu that displays this card
        MenuButtonScript menu;

        // Reference to die roller
        DieScript die;

        // Reference to current player
        PlayerClass currPlayer;

        // This is what keeps track of the phase of card choice
        CardPrefabState cardPrefabState;

        // Keeps track of which option was chosen
        int optionChosen;

        #endregion

        #region Initialization

        public void Start()
        {
            card = MonoBehaviour.FindObjectOfType<Deck>().Dequeue();
            titleMesh.text = card.title;
            descriptionMesh.text = card.description;
            option1.text = card.choices[0].Description;
            option2.text = card.choices[1].Description;
            option3.text = card.choices[2].Description;

            // get references to all necessary objects
            globals = MonoBehaviour.FindObjectOfType<GlobalsScript>();
            die = MonoBehaviour.FindObjectOfType<DieScript>().GetComponent<DieScript>();
            currPlayer = globals.GetPlayer();
            menu = MonoBehaviour.FindObjectOfType<MenuButtonScript>();

            // Add to player story
            globals.GetPlayer().Story += "-" + card.title + "- " + card.description + " ";

            // Initializes the card so that no option has been chosen yet
            cardPrefabState = CardPrefabState.Waiting;
            optionChosen = 0;

            // Sets the die to be inactive until it is needed
            die.gameObject.SetActive(false);
        }

        #endregion

        #region Button Methods

        // First button on card
        public void CardChoice1()
        {
            // Checks to see if an option has been chosen to prevent more than one from being selected
            if (cardPrefabState == CardPrefabState.Waiting)
            {
                // Records that an option has been selected and which option it is
                cardPrefabState = CardPrefabState.OptionChosen;
                optionChosen = 0;

                // Allows die to be rolled
                die.gameObject.SetActive(true);
                die.NeedsRoll = true;
            }
        }

        // Second button on card
        public void CardChoice2()
        {
            // Checks to see if an option has been chosen to prevent more than one from being selected
            if (cardPrefabState == CardPrefabState.Waiting)
            {
                // Records that an option has been selected and which option it is
                cardPrefabState = CardPrefabState.OptionChosen;
                optionChosen = 1;

                // Allows die to be rolled
                die.gameObject.SetActive(true);
                die.NeedsRoll = true;
            }
        }

        // Third button on card
        public void CardChoice3()
        {
            // Checks to see if an option has been chosen to prevent more than one from being selected
            if (cardPrefabState == CardPrefabState.Waiting)
            {
                // Records that an option has been selected and which option it is
                cardPrefabState = CardPrefabState.OptionChosen;
                optionChosen = 2;

                // Allows die to be rolled
                die.gameObject.SetActive(true);
                die.NeedsRoll = true;
            }
        }

        #endregion

        #region Public Methods

        // The method that ends the card
        public void exitMenuPhase()
        {
            globals.PlayerTurn += 1;
            //die.gameObject.SetActive(false);
            menu = MonoBehaviour.FindObjectOfType<MenuButtonScript>();
            menu.exitDrawCardPhase();
        }

        // This is the accessor for the card being used
        public Card GetCurrentCard()
        {
            return card;
        }

        // Update method, called every frame
        public void Update()
        {
            // Checks for whether an option has been chosen and whether the die has been rolled.
            // If both are true, commences with determining whether player won or not.
            if (cardPrefabState == CardPrefabState.OptionChosen && die.NeedsRoll == false)
            {
                // If player wins roll, apply winning effects.
                // Otherwise, the player has lost the roll and losing effects apply.
                if (card.choices[optionChosen].CheckResult() == true)
                {
                    OptionWin(optionChosen);
                }
                else
                {
                    OptionLose(optionChosen);
                }

                // Waits for a specified amount of time before removing card and sets state to exiting
                cardPrefabState = CardPrefabState.ExitInvoked;
                Invoke("exitMenuPhase", 5);
            }
        }

        #endregion

        #region Private Methods

        // Applies winning effects
        private void OptionWin(int whichOption)
        {
            // Applies all the winning conditions to the player's stats
            foreach (Effect effect in card.choices[whichOption].winEffects)
            {
                effect.ApplyEffect();
            }
            
            // Increases the player's victory points for winning
            currPlayer.VictoryPoints++;
        }

        // Applies losing effects
        private void OptionLose(int whichOption)
        {
            // Applies all the losing conditions to the player's stats
            foreach (Effect effect in card.choices[whichOption].lossEffects)
            {
                effect.ApplyEffect();
            }
        }

        #endregion

        #region Enumerations

        // These are the enumerations of the state in which the card prefab may be
        private enum CardPrefabState
        {
            Waiting,       // 0
            OptionChosen,  // 1
            ExitInvoked    // 2
        }

        #endregion
    }

}
