using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Card : MonoBehaviour {

    string title { get; set; }
    string description { get; set; }
    CardChoice[] choices { get; set; }

    public TextMesh titleMesh;
    public TextMesh descriptionMesh;
    public Text option1;
	public Text option2;
	public Text option3;
    public Card(string title, string description, CardChoice[] choices)
    {
        this.title = title;
        this.description = description;
        this.choices = choices;
<<<<<<< HEAD
        this.option1 = choices[0];
=======
>>>>>>> origin/master
    }

	// Use this for initialization
	void Start () {
        Card card = GlobalsScript.Instance.PlayDeck.Dequeue();
        titleMesh.text = card.title;
        descriptionMesh.text = card.description;
<<<<<<< HEAD
        //option1.guiText = card.choices[0].
	}
	
	// Update is called once per frame
	void Update () {
=======
        option1.text = choices[0].Description;
        option2.text = choices[1].Description;
        option3.text = choices[2].Description;
    }

    // Update is called once per frame
    void Update () {
>>>>>>> origin/master
	
	}
}
