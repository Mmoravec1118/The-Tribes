using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardChoice : MonoBehaviour {

    Effect[] winEffects;
    Effect[] lossEffects;
    string description;
    string Description
    {
        get
        {
            return description;
        }
    }
	public CardChoice(string description, Card.Traits trait, int toBeat, Effect[] winEffects, Effect[] lossEffects)
    {
        this.description = description;
        this.winEffects = winEffects;
        this.lossEffects = lossEffects;
    }
}

public class Effect
{
    int change;
    Card.Traits toChange;

    public Effect(int change, Card.Traits toChange)
    {
        this.change = change;
        this.toChange = toChange;
    }

    //public void MakeChange(Player player)
    //{

    //}
}
