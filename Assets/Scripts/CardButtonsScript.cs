using UnityEngine;
using System.Collections;

public class CardButtonsScript : MonoBehaviour {

    // card choice currently loaded into card
    CardChoice currCardChoice;
    Card currCard;

    // reference to die roller
    DieScript die;

    // reference to current player
    PlayerClass currPlayer;

    int cost;
    GlobalsScript.Traits trait;

    void Start()
    {
        // get cardChoice
        currCardChoice = GetComponent<CardChoice>();
        currCard = FindObjectOfType<Card>();

        // get die roller
        die = FindObjectOfType<DieScript>().GetComponent<DieScript>();

        currPlayer = GlobalsScript.Instance.GetPlayer();
    }

    #region Methods

    // first button of card
    public void CardChoice1()
    {
        trait = currCardChoice.GetTrait;
        cost = currCardChoice.GetEffectCost;
        die.NeedsRoll = true;
        CheckResult();
    }

    // second button on card
    public void CardChoice2()
    {
        trait = currCardChoice.GetTrait;
        cost = currCardChoice.GetEffectCost;
        die.NeedsRoll = true;
        CheckResult();
    }

    // third button on card
    public void CardChoice3()
    {
        trait = currCardChoice.GetTrait;
        cost = currCardChoice.GetEffectCost;
        die.NeedsRoll = true;
        CheckResult();
    }

    // checks result of player stats + die result against card cost
    void CheckResult()
    {
        if (!die.NeedsRoll)
        {
            switch (trait)
            {
                case GlobalsScript.Traits.Strength:
                    {
                        if (currPlayer.Strength + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Agility:
                    {
                        if (currPlayer.Agility + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Trust:
                    {
                        if (currPlayer.Trust + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Notoriety:
                    {
                        if (currPlayer.Notoriety + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Survival:
                    {
                        if (currPlayer.Survival + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                        }
                        break;
                    }
            }
        }
        else
        {
            currCard.description = "Roll Die and press Button again";
        }
    }

    #endregion  
}
