using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardChoice : MonoBehaviour {

    #region Fields

    //Fields
    Effect[] winEffects;
    Effect[] lossEffects;
    string description;
    string winText;
    string lossText;
    int cost;
    GlobalsScript.Traits currTrait;

    // reference to die roller
    DieScript die;

    bool win;
    // reference to current player
    PlayerClass currPlayer;
    Card currCard;

    #endregion

    #region Constructor

    public CardChoice(string description, string winText, string lossText, GlobalsScript.Traits trait, int toBeat, Effect[] winEffects, Effect[] lossEffects)
    {
        this.description = description;
        this.winEffects = winEffects;
        this.lossEffects = lossEffects;
		this.winText = winText;
		this.lossText = lossText;
        cost = toBeat;
        currTrait = trait;
        
    }

    #endregion

    #region Properties

    public string Description
    {
        get
        {
            return description;
        }
    }

    public int GetEffectCost
    {
        get
        {
            return cost;
        }
    }

    public GlobalsScript.Traits GetTrait
    {
        get
        {
            return currTrait;
        }
    }

    public string GetWinText
    {
        get
        {
            return winText;
        }
    }

    public string GetLoseText
    {
        get
        {
            return lossText;
        }
    }

    #endregion

    #region Button Methods

    // first button of card
    public void CardChoice1()
    {
        // get die roller
        die = FindObjectOfType<DieScript>().GetComponent<DieScript>();
        currPlayer = GlobalsScript.Instance.GetPlayer();
        currCard = FindObjectOfType<Card>();
        
        CheckResult();
        if (win)
        {
            //foreach (Effect effect in winEffects)
            //{
            //    effect.ApplyEffect();
            //}
            currPlayer.Strength++;
            die.NeedsRoll = true;
        }
        else
        {
            //foreach (Effect effect in lossEffects)
            //{
            //    effect.ApplyEffect();
            //}
            currPlayer.Wood--;
            die.NeedsRoll = true;
        }
    }

    // second button on card
    public void CardChoice2()
    {
        // get die roller
        die = FindObjectOfType<DieScript>().GetComponent<DieScript>();
        currPlayer = GlobalsScript.Instance.GetPlayer();
        currCard = FindObjectOfType<Card>();
        //die.NeedsRoll = true;
        CheckResult();
        if (win)
        {
            //foreach (Effect effect in winEffects)
            //{
            //    effect.ApplyEffect();
            //}
            currPlayer.Trust++;
            die.NeedsRoll = true;
        }
        else
        {
            //foreach (Effect effect in lossEffects)
            //{
            //    effect.ApplyEffect();
            //}
            currPlayer.Food--;
            die.NeedsRoll = true;
        }
    }

    // third button on card
    public void CardChoice3()
    {
        // get die roller
        die = FindObjectOfType<DieScript>().GetComponent<DieScript>();
        currPlayer = GlobalsScript.Instance.GetPlayer();
        currCard = FindObjectOfType<Card>();
        //die.NeedsRoll = true;
        CheckResult();
        if (win)
        {
            //foreach (Effect effect in winEffects)
            //{
            //    effect.ApplyEffect();
            //}
            currPlayer.Notoriety++;
            die.NeedsRoll = true;
        }
        else
        {
            //foreach (Effect effect in lossEffects)
            //{
            //    effect.ApplyEffect();
            //}
            currPlayer.People--;
            die.NeedsRoll = true;
        }
    }

    // checks result of player stats + die result against card cost
    void CheckResult()
    {
        if (!die.NeedsRoll)
        {
            switch (currTrait)
            {
                case GlobalsScript.Traits.Strength:
                    {
                        if (currPlayer.Strength + die.DieResult >= cost)
                        {
                            currCard.description = winText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = lossText;
                            win = false;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Agility:
                    {
                        if (currPlayer.Agility + die.DieResult >= cost)
                        {
                            currCard.description = winText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = lossText;
                            win = false;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Trust:
                    {
                        if (currPlayer.Trust + die.DieResult >= cost)
                        {
                            currCard.description = winText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = lossText;
                            win = false;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Notoriety:
                    {
                        if (currPlayer.Notoriety + die.DieResult >= cost)
                        {
                            currCard.description = winText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = lossText;
                            win = false;
                        }
                        break;
                    }
                case GlobalsScript.Traits.Survival:
                    {
                        if (currPlayer.Survival + die.DieResult >= cost)
                        {
                            currCard.description = winText;
                            win = true;
                        }
                        else
                        {
                            currCard.description = lossText;
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



public class Effect
{
    #region

    // value to adjust and what to adjust
    int change;
    GlobalsScript.Traits toChangeTrait;
	GlobalsScript.Resources toChangeResource;

    // bool if things should change and what to change
    bool ChangeStuff = false;

    bool trait = false;
    bool resource = false;

    #endregion

    #region Constructors

    public Effect(int change, GlobalsScript.Traits toChangeTrait)
    {
        this.change = change;
        this.toChangeTrait = toChangeTrait;
        trait = true;
    }

	public Effect(int change, GlobalsScript.Resources toChangeResource)
	{
		this.change = change;
		this.toChangeResource = toChangeResource;
        resource = true;
	}

    #endregion

    #region Method

    public void ApplyEffect()
    {
        #region Trait Change

        // check if stats should change
        if (trait)
        {
            switch (toChangeTrait)
            {

                case GlobalsScript.Traits.Agility:
                    {
                        GlobalsScript.Instance.GetPlayer().Agility += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Traits.Strength:
                    {
                        GlobalsScript.Instance.GetPlayer().Strength += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Traits.Notoriety:
                    {
                        GlobalsScript.Instance.GetPlayer().Notoriety += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Traits.Survival:
                    {
                        GlobalsScript.Instance.GetPlayer().Survival += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Traits.Trust:
                    {
                        GlobalsScript.Instance.GetPlayer().Trust += change;
                        ChangeStuff = false;
                        break;
                    }
            }
        }
        #endregion

        #region Resource Change

        // chacks if resources should change
        else if (resource)
        {
            switch (toChangeResource)
            {

                case GlobalsScript.Resources.Wood:
                    {
                        GlobalsScript.Instance.GetPlayer().Wood += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Resources.Stone:
                    {
                        GlobalsScript.Instance.GetPlayer().Stone += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Resources.Food:
                    {
                        GlobalsScript.Instance.GetPlayer().Food += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Resources.People:
                    {
                        GlobalsScript.Instance.GetPlayer().People += change;
                        ChangeStuff = false;
                        break;
                    }
            }
        }
        #endregion  
    }

    #endregion  

    #region Properties

    public int GetChange
    {
        get
        {
            return change;
        }
    }

    public GlobalsScript.Resources GetResource
    {
        get
        {
            return toChangeResource;
        }
    }

    public GlobalsScript.Traits GetTrait
    {
        get
        {
            return toChangeTrait;
        }
    }

    public bool SetChange
    {
        set
        {
            ChangeStuff = value;
        }
    }

    #endregion
}
