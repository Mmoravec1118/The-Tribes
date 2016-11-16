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

    Effect winEffect1;
    Effect winEffect2;
    Effect winEffect3;

    Effect lossEffect1;
    Effect lossEffect2;
    Effect lossEffect3;

    bool win;

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

        winEffect1 = currCardChoice.GetWinEffect(0);
        winEffect2 = currCardChoice.GetWinEffect(1);
        winEffect3 = currCardChoice.GetWinEffect(2);

        lossEffect1 = currCardChoice.GetLossEffect(0);
        lossEffect2 = currCardChoice.GetLossEffect(1);
        lossEffect3 = currCardChoice.GetLossEffect(2);

    }

    #region Methods

    // first button of card
    public void CardChoice1()
    {
        trait = currCardChoice.GetTrait;
        cost = currCardChoice.GetEffectCost;
        die.NeedsRoll = true;
        CheckResult();
        if (win)
        {
            winEffect1.SetChange = true;
        }
        else
        {
            lossEffect1.SetChange = false;
        }
    }

    // second button on card
    public void CardChoice2()
    {
        trait = currCardChoice.GetTrait;
        cost = currCardChoice.GetEffectCost;
        die.NeedsRoll = true;
        CheckResult();
        if (win)
        {
            winEffect2.SetChange = true;
        }
        else
        {
            lossEffect2.SetChange = false;
        }
    }

    // third button on card
    public void CardChoice3()
    {
        trait = currCardChoice.GetTrait;
        cost = currCardChoice.GetEffectCost;
        die.NeedsRoll = true;
        CheckResult();
        if (win)
        {
            winEffect3.SetChange = true;
        }
        else
        {
            lossEffect3.SetChange = false;
        }
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
                            win = true;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                            win = false;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Agility:
                    {
                        if (currPlayer.Agility + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                            win = false;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Trust:
                    {
                        if (currPlayer.Trust + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                            win = false;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Notoriety:
                    {
                        if (currPlayer.Notoriety + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                            win = false;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Survival:
                    {
                        if (currPlayer.Survival + die.DieResult >= cost)
                        {
                            currCard.description = currCardChoice.GetWinText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = currCardChoice.GetLoseText;
                            win = false;
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
