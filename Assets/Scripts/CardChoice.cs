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

    #region Methods

    public Effect GetWinEffect(int effectNum)
    {
        return winEffects[effectNum];
    }

    public Effect GetLossEffect(int effectNum)
    {
        return lossEffects[effectNum];
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

    #endregion

    #region Constructors

    public Effect(int change, GlobalsScript.Traits toChangeTrait)
    {
        this.change = change;
        this.toChangeTrait = toChangeTrait;
    }

	public Effect(int change, GlobalsScript.Resources toChangeResource)
	{
		this.change = change;
		this.toChangeResource = toChangeResource;
	}

    #endregion

    #region Method

    public void ApplyEffect(bool trait)
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
        else if (!trait)
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
