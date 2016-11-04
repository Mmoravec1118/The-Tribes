using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {


	//fields for a new deck
	public static Queue<Card> deck;



	// Use this for initialization
	void Start () {
		
	//instantiate new deck on start
		deck = new Queue<Card>();

		//add items to the queue.
		//CARD 1
		//ORC INVASION
		deck.Enqueue (
			//new card one
			new Card ("Orc Invasion",
				"Your settlement has been invaded by orcs, they look like they want what you have.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You try to run the orcs off with your military might(10).",
					"You successfully chase off the orcs",
					"You fail to chase off the orcs",
				//win effect,
					Card.Traits.Strength,
					10,
					new Effect[]{
						new Effect(1, Card.Resources.Wood),
						new Effect(1, Card.Resources.Stone),
						new Effect(1, Card.Resources.Food)
					},
					//lose effects
						new Effect[]{
						new Effect(-1, Card.Resources.Wood),
						new Effect(-1, Card.Resources.Stone),
						new Effect(-1, Card.Resources.Food)}
				),

					//choice 2
					new CardChoice ("AGILITY - Using stealth, you take down the orc leader(10)",
						"The Orc Leader dies",
						"The Orc Leader Thwards your assassination attempt",
						Card.Traits.Agility,
						10,
						//win effect
						new Effect[]{ 
						new Effect(2, Card.Resources.People),
						new Effect(1, Card.Traits.Strength)
					},
						//lose effect
					new Effect[]{
							new Effect(-1, Card.Traits.Strength)}
					
					),

					//choice 3
					new CardChoice ("NOTORIETY - Maybe the Orcs are too afraid of you to attack and will offer a peace offering.(12)",
						"They cower in fear at you!  They offer the peace offering",
						"They laugh at you, taking your resources",
						Card.Traits.Notoriety,
						12,
						//win effects
						new Effect[]{
						new Effect(1, Card.Resources.Wood),
						new Effect(1, Card.Resources.Stone),
						new Effect(1, Card.Resources.Food)	
					},
						//lose effect
						new Effect[]{ 
						new Effect(-1, Card.Traits.Notoriety),
						new Effect(-1, Card.Resources.Stone),
						new Effect(-1, Card.Resources.Wood),
						new Effect(-1, Card.Resources.Food)
					})
				
			
				}
			)
			//end of enqueue card 1
		);

		//add second card
		//CARD 2
		//SPIDER INFESTATION
		deck.Enqueue (
			//new card one
			new Card ("Spider Infestation",
				"Your settlement is about to be overrun by giant spiders.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You try to crush the spiders (12).",
					"The Spiders were crushed and the village is safe, but you gain nothing",
					"The spiders take some of your villagers for food",
					//win effect,
					Card.Traits.Strength,
					12,
					new Effect[]{
						new Effect(0, Card.Resources.People),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, Card.Resources.People)}
				),

					//choice 2
					new CardChoice ("TRUST - You try to communicate with the spiders(14)",
						"The spiders are actually highly intelligent and you form an alliance!",
						"You fail to communicate with the spiders.",
						Card.Traits.Trust,
						14,
						//win effect
						new Effect[]{ 
							new Effect(2, Card.Traits.Strength),
							new Effect(1, Card.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, Card.Traits.Trust),
							new Effect(-2, Card.Resources.People)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You attempt to avoid conflict by leaving your settlement (10)",
						"You avoid the spiders and find more resources!",
						"You avoid the spiders but some of your people die in the wilderness.",
						Card.Traits.Survival,
						10,
						//win effects
						new Effect[]{
							new Effect(1, Card.Resources.Wood),
							new Effect(1, Card.Resources.Food)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, Card.Resources.People),
							new Effect(-1, Card.Resources.Food)
						})


				}
			)
			//end of enqueue card 2
		);

		//add card 3
		//CARD 3
		//MINOTAUR RUTTING SEASON
		deck.Enqueue (
			//new card one
			new Card ("Minotaur Rutting Season",
				"The local minotaur population is currently a riled up and could cause severe damage to your settlement.",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - You try to Come to an agreement with the Minotaur population to avoid your settlement(7).",
					"They Agree to avoid your settlement.",
					"Minotaurs shag during the meeting and break things...",
					//win effect,
					Card.Traits.Trust,
					7,
					new Effect[]{
						new Effect(1, Card.Traits.Trust),
					},
					//lose effects
					new Effect[]{
						new Effect(-1, Card.Resources.Wood),
						new Effect(-1, Card.Traits.Trust)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to mask your settlement with bull scent.",
						"Your settlement survives and you find extra resources outside afterward.",
						"You used the wrong scent and instead attracted Minotaurs.  Oops.",
						Card.Traits.Survival,
						9,
						//win effect
						new Effect[]{ 
							new Effect(2, Card.Resources.Food),
							new Effect(2, Card.Resources.Wood),
							new Effect(1, Card.Traits.Survival)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, Card.Resources.Wood),
							new Effect(-2, Card.Resources.Stone)}
					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to use your reputation to scare the Minotaurs off(14)",
						"The Minotaurs offer the peace offering",
						"The Minotaurs see your notoriety as a threat and instead launch an attack on your settlement.",
						Card.Traits.Notoriety,
						14,
						//win effects
						new Effect[]{
							new Effect(1, Card.Resources.Wood),
							new Effect(1, Card.Resources.Stone),
							new Effect(1, Card.Resources.Food),
							new Effect(1, Card.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, Card.Traits.Notoriety),
							new Effect(-2, Card.Resources.Stone),
							new Effect(-2, Card.Resources.Wood),
							new Effect(-2, Card.Resources.Food)
						})
				}
			)
			//end of enqueue card 2
		);


		//CARD 4
		//PIXIES AT PLAY
		deck.Enqueue (
			//new card one
			new Card ("Pixies at play",
				"Mischevious Pixies have left their forest to 'investigate' your settlement.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You attempt to murder the pixies(12).",
					"You destroy the pixies and take their resources for yourself.",
					"The pixies enrage and kill some of your villagers in their sleep.",
					//win effect,
					Card.Traits.Strength,
					12,
					new Effect[]{
						new Effect(1, Card.Traits.Notoriety),
						new Effect(1, Card.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, Card.Traits.Strength),
						new Effect(-1, Card.Resources.People)}
				),

					//choice 2
					new CardChoice ("TRUST - You Attempt to persuade the pixies of the fun in protecting your settlement with their magic(7)",
						"They find the thought amusing and make a magical barrier for your settlement.",
						"The pixies find it more amusing to makea barrier that instead weakens your settlement to future threats...",
						Card.Traits.Trust,
						7,
						//win effect
						new Effect[]{ 
							new Effect(1, Card.Traits.Strength),
							new Effect(1, Card.Traits.Agility),
							new Effect(1, Card.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, Card.Traits.Strength),
							new Effect(-1, Card.Traits.Agility),
							new Effect(-1, Card.Traits.Trust)
						}

					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to enslave the pixies.(12)",
						"You somehow manage to enslave the entire pixie colony and they become slaves for your settlement.",
						"The pixies enslave part of your settlement and drag them into the woods never to be seen again.",
						Card.Traits.Notoriety,
						12,
						//win effects
						new Effect[]{
							new Effect(2, Card.Resources.People),
							new Effect(1, Card.Traits.Notoriety),
							new Effect(1, Card.Traits.Strength)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, Card.Resources.People),
							new Effect(-1, Card.Traits.Notoriety),
							new Effect(-1, Card.Traits.Strength)
						})
				}
			)
			//end of enqueue card 4
		);


		//add items to the queue.
		//CARD 5
		//WIZARD PROTEST
		deck.Enqueue (
			//new card one
			new Card ("Wizard Protest",
				"The Local Wizard is fed up with his living conditions and decides to threaten your settlement until it improves.",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - You offer the Wizard better living conditions by renovating his tower(10).",
					"He appreciates the offer and at the expense of a few resources, he makes peace.",
					"The wizard claims your efforts are too late, and takes resources by force",
					//win effect,
					Card.Traits.Trust,
					10,
					new Effect[]{
						new Effect(2, Card.Traits.Trust),
						new Effect(-1, Card.Resources.Stone),
						new Effect(-1, Card.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, Card.Traits.Strength),
						new Effect(-1, Card.Traits.Agility),
						new Effect(-1, Card.Resources.Wood),
						new Effect(-1, Card.Resources.Stone)
					}
				),

					//choice 2
					new CardChoice ("AGILITY - You attempt to stop the wizard before he can do any damage(12)",
						"You sneak past the wizard and knock him out",
						"The wizard blows up your village",
						Card.Traits.Agility,
						12,
						//win effect
						new Effect[]{ 
							new Effect(2, Card.Traits.Agility),
							new Effect(-1, Card.Traits.Strength)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, Card.Traits.Strength),
							new Effect(-1, Card.Traits.Agility)
						}

					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to intimidate the Wizard into rescinding his attack.(15)",
						"The Wizard is no match for you, as you outlevel him significantly.  He begs for forgiveness.",
						"You get ganked by the Wizard and look foolish.",
						Card.Traits.Notoriety,
						15,
						//win effects
						new Effect[]{
							new Effect(1, Card.Traits.Strength),
							new Effect(1, Card.Traits.Notoriety)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, Card.Traits.Notoriety),
							new Effect(-1, Card.Traits.Strength),
							new Effect(-1, Card.Resources.People)
						})
				}
			)
			//end of enqueue card 5
		);

		//add items to the queue.
		//CARD 6
		//THRILL OF THE HUNT
		deck.Enqueue (
			//new card one
			new Card ("Thrill of the Hunt",
				"A vicious hunter begins to stalk and hunt your settlement for sport!",

				//choice 1
				new CardChoice[] {new CardChoice ("NOTORIETY - You attempt to use your reputation to scare off the predatory hunter(14).",
					"The hunter decides the thrill of the sport is not worth his own life.",
					"The hunter loves it when his prey puts up a fight and insteads turns up the pressure.",
					//win effect,
					Card.Traits.Notoriety,
					14,
					new Effect[]{
						new Effect(3, Card.Traits.Notoriety),
						new Effect(1, Card.Traits.Strength),
						new Effect(1, Card.Traits.Agility)
					},
					//lose effects
					new Effect[]{
						new Effect(-3, Card.Resources.People),
						new Effect(-1, Card.Traits.Strength),
						new Effect(-1, Card.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("Trust - You attempt to convince the hunter that you are not a worthwhile target and instead can supply him.(10)",
						"The hunter agrees, trading some resources for the ones he requires.",
						"The hunter isn't phased by politics, and instead takes resources by force, killing some of your people in the process.",
						Card.Traits.Trust,
						10,
						//win effect
						new Effect[]{ 
							new Effect(1, Card.Resources.Wood),
							new Effect(1, Card.Resources.Stone),
							new Effect(-1, Card.Resources.Food)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, Card.Resources.Food),
							new Effect(-2, Card.Resources.People)
						}

					),

					//choice 3
					new CardChoice ("STRENGTH - You attempt to hunt the hunter, engaging in a deadly bloodsport.(12)",
						"The hunter becomes the prey and your settlement eliminates him and takes his resources.",
						"You fight a hard battle, but lose settlers in the process.",
						Card.Traits.Strength,
						12,
						//win effects
						new Effect[]{
							new Effect(2, Card.Resources.Food),
							new Effect(2, Card.Traits.Notoriety)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, Card.Resources.People),
							new Effect(-1, Card.Resources.Wood),
							new Effect(-1, Card.Resources.Stone)
						})
				}
			)
			//end of enqueue card 6
		);


		//add items to the queue.
		//CARD 7
		//WILDFIRE
		deck.Enqueue (
			//new card one
			new Card ("Wildfire",
				"Your Settlement finds itself in the path of a raging wildfire!",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You attempt to abandon your current settlement with your villagers taking anything you can carry.",
					"You manage to escape, losing no resources but gaining some survival rank.",
					"You fail to evacuate in time, and while no one is injured, your resources are burnt in the blaze.",
					//win effect,
					Card.Traits.Agility,
					10,
					new Effect[]{
						new Effect(1, Card.Traits.Survival),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, Card.Resources.Wood),
						new Effect(-2, Card.Resources.Food)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to dig fire trenches between the fire and your village to contain the fire.(12)",
						"The trench works and your settlement is spared and the new ditch serves as a new infrastructure to irrigate future crops.",
						"The trench was not complete in time and your village is partially scorched.",
						Card.Traits.Survival,
						12,
						//win effect
						new Effect[]{ 
							new Effect(2, Card.Resources.Food),
							new Effect(1, Card.Traits.Strength)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, Card.Resources.Wood),
							new Effect(-1, Card.Resources.Food)
						}
					),

					//choice 3
					new CardChoice ("STRENGTH - You take some villagers to attempt to extinguish the fire before it reaches the village.(13)",
						"Your efforts save the village and you gain some food and wood in the scramble.",
						"You lose not only a hefty portion of your village, but a large number of villagers",
						Card.Traits.Strength,
						13,
						//win effects
						new Effect[]{
							new Effect(2, Card.Resources.Wood),
							new Effect(1, Card.Resources.Food)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, Card.Resources.People),
							new Effect(-2, Card.Resources.Wood),
							new Effect(-2, Card.Resources.Food),
							new Effect(-1, Card.Traits.Survival)
						})
				}
			)
			//end of enqueue card 7
		);



	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//removed card from the deck
	Card Dequeue (Card card)
	{
		//dequeue the card from the top of the deck
		return deck.Dequeue ();
	}


}
