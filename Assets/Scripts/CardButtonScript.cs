using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityEngine.UI;

public class CardButtonScript : MonoBehaviour {

    #region fields

    public GameObject toolTipPrefab;
    GameObject thisToolTip;
    public int cardButtonNumber;

    #endregion


    // Use this for initialization
    void Start ()
    {
        //get tooltip from parent class
        //toolTipPrefab = GetComponentInParent<CardPrefab>().toolTipPrefab;
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    //pulls the information to be displayed on hover.
    public void MouseOver()
    {
        //destroy the tooltip if it exists already
        if (thisToolTip)
        {
            Destroy(thisToolTip);
        }

        //instantiate new tooltip prefab
        thisToolTip = Instantiate(toolTipPrefab);
        thisToolTip.transform.SetParent(transform, false);

        //offsets tooltip position
        thisToolTip.GetComponent<RectTransform>().localPosition = new Vector3(175, 20);

        //set data
        thisToolTip.GetComponentInChildren<Text>().text = 
            GetComponentInParent<CardPrefab>().GetCurrentCard().choices[cardButtonNumber].GetWinEffects()
            + GetComponentInParent<CardPrefab>().GetCurrentCard().choices[cardButtonNumber].GetLossEffects();
    }

    //destroy
    public void MouseExit()
    {
        Destroy(thisToolTip);
    }
}
