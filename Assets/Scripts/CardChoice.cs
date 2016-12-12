﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;

public class CardChoice
{

    #region Fields

    //Fields
    public Effect[] winEffects;
    public Effect[] lossEffects;
    string description;
    string winText;
    string lossText;
    int cost;
    GlobalsScript.Traits currTrait;

    GlobalsScript globals;
    MenuButtonScript menu;

    // reference to die roller
    DieScript die;

    bool win;
    // reference to current player
    PlayerClass currPlayer;
    CardPrefab currCard;

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

    // checks result of player stats + die result against card cost
    public bool CheckResult()
    {
        globals = MonoBehaviour.FindObjectOfType<GlobalsScript>();
        die = MonoBehaviour.FindObjectOfType<DieScript>().GetComponent<DieScript>();
        currCard = MonoBehaviour.FindObjectOfType<CardPrefab>();
        currPlayer = globals.GetPlayer();

        switch (currTrait)
        {
            case GlobalsScript.Traits.Strength:
                {
                    if (currPlayer.Strength + die.DieResult >= cost)
                    {
                        currCard.descriptionMesh.text = winText;
                        return true;
                    }
                    else
                    {
                        currCard.descriptionMesh.text = lossText;
                        return false;
                    }
                   // break;
                }
            case GlobalsScript.Traits.Agility:
                {
                    if (currPlayer.Agility + die.DieResult >= cost)
                    {
                        currCard.descriptionMesh.text = winText;
                        return true;
                    }
                    else
                    {
                        currCard.descriptionMesh.text = lossText;
                        return false;
                    }
                  //  break;
                }
            case GlobalsScript.Traits.Trust:
                {
                    if (currPlayer.Trust + die.DieResult >= cost)
                    {
                        currCard.descriptionMesh.text = winText;
                        return true;
                    }
                    else
                    {
                        currCard.descriptionMesh.text = lossText;
                        return false;
                    }
                 //   break;
                }
            case GlobalsScript.Traits.Notoriety:
                {
                    if (currPlayer.Notoriety + die.DieResult >= cost)
                    {
                        currCard.descriptionMesh.text = winText;
                        return true;
                    }
                    else
                    {
                        currCard.descriptionMesh.text = lossText;
                        return false;
                    }
                 //   break;
                }
            case GlobalsScript.Traits.Survival:
                {
                    if (currPlayer.Survival + die.DieResult >= cost)
                    {
                        currCard.descriptionMesh.text = winText;
                        return true;
                    }
                    else
                    {
                        currCard.descriptionMesh.text = lossText;
                        return false;
                    }
              //      break;
                }
            default:
                {
                    return false;
                }

        }
    }
}

#endregion





public class Effect 
{
    #region Fields

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
       // DontDestroyOnLoad(this);
    }

	public Effect(int change, GlobalsScript.Resources toChangeResource)
	{
		this.change = change;
		this.toChangeResource = toChangeResource;
        resource = true;
        //DontDestroyOnLoad(this);

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
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().Agility += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Traits.Strength:
                    {
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().Strength += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Traits.Notoriety:
                    {
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().Notoriety += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Traits.Survival:
                    {
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().Survival += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Traits.Trust:
                    {
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().Trust += change;
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
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().Wood += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Resources.Stone:
                    {
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().Stone += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Resources.Food:
                    {
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().Food += change;
                        ChangeStuff = false;
                        break;
                    }
                case GlobalsScript.Resources.People:
                    {
                        MonoBehaviour.FindObjectOfType<GlobalsScript>().GetPlayer().People += change;
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
