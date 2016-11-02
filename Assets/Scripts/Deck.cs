using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {


	//fields for a new deck
	Queue<Card> deck;



	// Use this for initialization
	void Start () {
	//instantiate new deck on start
		deck = new Queue<Card>();

		//add items to the queue.
		deck.Enqueue (
			//new card
			new Card ("Orc Invasion",
				"Your settlement has been invaded by orcs, they look like they want what you have.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You run the orcs off with your military might(10).",
				//win effect
						new Effect[]{ },
					//lose effects
						new Effect[]{ }),

					//choice 2
					new CardChoice ("AGILITY - Using stealth, you take down the orc leader(10)",
						//win effect
						new Effect[]{ },
						//lose effect
						new Effect{ }),

					//choice 3
					new CardChoice ("NOTORIETY - Orcs are too afraid of you to attack, they offer a peace offering.(12)",
						//win effects
						new Effect[]{ },
						//lose effect
						new Effect[]{ })
				}
			)
		);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//removed card from the deck
	void Dequeue (Card card)
	{
		
	}


}
