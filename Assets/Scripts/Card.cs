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
    }

    #endregion

    #region Start

    // Use this for initialization
    void Start () {
        Card card = GlobalsScript.Instance.PlayDeck.Dequeue();
        titleMesh.text = card.title;
        descriptionMesh.text = card.description;
        option1.text = card.choices[0].Description;
        option2.text = card.choices[1].Description;
        option3.text = card.choices[2].Description;
    }

    #endregion
}
