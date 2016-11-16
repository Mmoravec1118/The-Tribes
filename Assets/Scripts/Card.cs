using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Card : MonoBehaviour {

    #region Fields

    // deck reference
    public Deck deck;

    // title text
    public string title { get; set; }

    // descrtiption text
    public string description { get; set; }

    // card choice infromation
    public CardChoice[] choices { get; set; }

    // references to card items
    [SerializeField] Text titleMesh;
    [SerializeField] Text descriptionMesh;
    [SerializeField] Text option1;
    [SerializeField] Text option2;
    [SerializeField] Text option3;

    #endregion

    #region Constructor

    public Card(string title, string description, CardChoice[] choices)
    {
        this.title = title;
        this.description = description;
        this.choices = choices;
//<<<<<<< HEAD
		//this.option1 = choices [0];
//=======
//>>>>>>> refs/remotes/origin/master
    }

    #endregion

    #region Sart

    // Use this for initialization
    void Start () {
        Card card = GlobalsScript.Instance.PlayDeck.Dequeue();
        titleMesh.text = card.title;
        descriptionMesh.text = card.description;
<<<<<<< HEAD
//<<<<<<< HEAD
		//option1.guiText.GetComponent<TextMesh>().text = card.choices [0];
		//option2.guiText = card.choices [1];
		//option3.guiText = card.choices [2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
//=======
       //option1.text = card.choices[0].Description;
        //option2.text = card.choices[1].Description;
        //option3.text = card.choices[2].Description;
=======
        option1.text = card.choices[0].Description;
        option2.text = card.choices[1].Description;
        option3.text = card.choices[2].Description;
    }

    #endregion
>>>>>>> refs/remotes/origin/master
}
    // Update is called once per frame
//>>>>>>> refs/remotes/origin/master