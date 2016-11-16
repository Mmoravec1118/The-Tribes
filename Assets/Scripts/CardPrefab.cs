using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class CardPrefab : MonoBehaviour
    {
        // references to card items
        [SerializeField]
        Text titleMesh;
        [SerializeField]
        public Text descriptionMesh;
        [SerializeField]
        Text option1;
        [SerializeField]
        Text option2;
        [SerializeField]
        Text option3;

        Card card;

        public CardChoice[] choices { get; set; }

        public void Start()
        {
            Card card = MonoBehaviour.FindObjectOfType<GlobalsScript>().PlayDeck.Dequeue();
            titleMesh.text = card.title;
            descriptionMesh.text = card.description;
            choices = card.choices;
            option1.text = card.choices[0].Description;
            option2.text = card.choices[1].Description;
            option3.text = card.choices[2].Description;
        }
    }
}
