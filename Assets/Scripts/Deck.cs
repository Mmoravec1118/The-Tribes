using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

    private static Deck instance;
    public static Deck Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Deck();
            }
            return instance;
        }
    }
	//fields for a new deck
	public Queue<Card> deck;
    public GameObject cardPrefab; 

    public Deck()
        {
        Start();
        }
	// Use this for initialization
	void Start () {
		
	//instantiate new deck on start
		deck = new Queue<Card>();
        cardPrefab = Resources.Load("CARD_PREFAB") as GameObject;
        //add items to the queue------------------------------------------------------------------------------------------------------------------------
        //CARD 1----------------------------------------------------------------------------------------------------------------------------------------
        //ORC INVASION----------------------------------------------------------------------------------------------------------------------------------
        deck.Enqueue (
			//new card one
			new Card ("Orc Invasion",
				"Your settlement has been invaded by orcs, they look like they want what you have.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You try to run the orcs off with your military might(10).",
					"You successfully chase off the orcs",
					"You fail to chase off the orcs",
				//win effect,
					GlobalsScript.Traits.Strength,
					10,
					new Effect[]{
						new Effect(1, GlobalsScript.Resources.Wood),
						new Effect(1, GlobalsScript.Resources.Stone),
						new Effect(1, GlobalsScript.Resources.Food)
					},
					//lose effects
						new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Resources.Stone),
						new Effect(-1, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("AGILITY - Using stealth, you take down the orc leader(10)",
						"The Orc Leader dies",
						"The Orc Leader Thwards your assassination attempt",
						GlobalsScript.Traits.Agility,
						10,
						//win effect
						new Effect[]{ 
						new Effect(2, GlobalsScript.Resources.People),
						new Effect(1, GlobalsScript.Traits.Strength)
					},
						//lose effect
					new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Strength)}
					
					),

					//choice 3
					new CardChoice ("NOTORIETY - Maybe the Orcs are too afraid of you to attack and will offer a peace offering.(12)",
						"They cower in fear at you!  They offer the peace offering",
						"They laugh at you, taking your resources",
						GlobalsScript.Traits.Notoriety,
						12,
						//win effects
						new Effect[]{
						new Effect(1, GlobalsScript.Resources.Wood),
						new Effect(1, GlobalsScript.Resources.Stone),
						new Effect(1, GlobalsScript.Resources.Food)	
					},
						//lose effect
						new Effect[]{ 
						new Effect(-1, GlobalsScript.Traits.Notoriety),
						new Effect(-1, GlobalsScript.Resources.Stone),
						new Effect(-1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Resources.Food)
					})
				
			
				}
			)
			//end of enqueue card 1
		);

		//add second card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 2----------------------------------------------------------------------------------------------------------------------------------------
		//SPIDER INFESTATION----------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Spider Infestation",
				"Your settlement is about to be overrun by giant spiders.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You try to crush the spiders (12).",
					"The Spiders were crushed and the village is safe, but you gain nothing",
					"The spiders take some of your villagers for food",
					//win effect,
					GlobalsScript.Traits.Strength,
					12,
					new Effect[]{
						new Effect(0, GlobalsScript.Resources.People),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, GlobalsScript.Resources.People)}
				),

					//choice 2
					new CardChoice ("TRUST - You try to communicate with the spiders(14)",
						"The spiders are actually highly intelligent and you form an alliance!",
						"You fail to communicate with the spiders.",
						GlobalsScript.Traits.Trust,
						14,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Strength),
							new Effect(1, GlobalsScript.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Trust),
							new Effect(-2, GlobalsScript.Resources.People)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You attempt to avoid conflict by leaving your settlement (10)",
						"You avoid the spiders and find more resources!",
						"You avoid the spiders but some of your people die in the wilderness.",
						GlobalsScript.Traits.Survival,
						10,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Food)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Resources.People),
							new Effect(-1, GlobalsScript.Resources.Food)
						})


				}
			)
			//end of enqueue card 2
		);

		//add card 3------------------------------------------------------------------------------------------------------------------------------------
		//CARD 3----------------------------------------------------------------------------------------------------------------------------------------
		//MINOTAUR RUTTING SEASON-----------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Minotaur Rutting Season",
				"The local minotaur population is currently a riled up and could cause severe damage to your settlement.",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - You try to Come to an agreement with the Minotaur population to avoid your settlement(7).",
					"They Agree to avoid your settlement.",
					"Minotaurs shag during the meeting and break things...",
					//win effect,
					GlobalsScript.Traits.Trust,
					7,
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Trust),
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Traits.Trust)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to mask your settlement with bull scent.",
						"Your settlement survives and you find extra resources outside afterward.",
						"You used the wrong scent and instead attracted Minotaurs.  Oops.",
						GlobalsScript.Traits.Survival,
						9,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.Food),
							new Effect(2, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Traits.Survival)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, GlobalsScript.Resources.Wood),
							new Effect(-2, GlobalsScript.Resources.Stone)}
					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to use your reputation to scare the Minotaurs off(14)",
						"The Minotaurs offer the peace offering",
						"The Minotaurs see your notoriety as a threat and instead launch an attack on your settlement.",
						GlobalsScript.Traits.Notoriety,
						14,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Stone),
							new Effect(1, GlobalsScript.Resources.Food),
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-2, GlobalsScript.Resources.Stone),
							new Effect(-2, GlobalsScript.Resources.Wood),
							new Effect(-2, GlobalsScript.Resources.Food)
						})
				}
			)
			//end of enqueue card 2
		);


		//CARD 4----------------------------------------------------------------------------------------------------------------------------------------
		//PIXIES AT PLAY--------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Pixies at play",
				"Mischevious Pixies have left their forest to 'investigate' your settlement.",

				//choice 1
				new CardChoice[] {new CardChoice ("STRENGTH - You attempt to murder the pixies(12).",
					"You destroy the pixies and take their resources for yourself.",
					"The pixies enrage and kill some of your villagers in their sleep.",
					//win effect,
					GlobalsScript.Traits.Strength,
					12,
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Notoriety),
						new Effect(1, GlobalsScript.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Traits.Strength),
						new Effect(-1, GlobalsScript.Resources.People)}
				),

					//choice 2
					new CardChoice ("TRUST - You Attempt to persuade the pixies of the fun in protecting your settlement with their magic(7)",
						"They find the thought amusing and make a magical barrier for your settlement.",
						"The pixies find it more amusing to makea barrier that instead weakens your settlement to future threats...",
						GlobalsScript.Traits.Trust,
						7,
						//win effect
						new Effect[]{ 
							new Effect(1, GlobalsScript.Traits.Strength),
							new Effect(1, GlobalsScript.Traits.Agility),
							new Effect(1, GlobalsScript.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Strength),
							new Effect(-1, GlobalsScript.Traits.Agility),
							new Effect(-1, GlobalsScript.Traits.Trust)
						}

					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to enslave the pixies.(12)",
						"You somehow manage to enslave the entire pixie colony and they become slaves for your settlement.",
						"The pixies enslave part of your settlement and drag them into the woods never to be seen again.",
						GlobalsScript.Traits.Notoriety,
						12,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Resources.People),
							new Effect(1, GlobalsScript.Traits.Notoriety),
							new Effect(1, GlobalsScript.Traits.Strength)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-1, GlobalsScript.Traits.Strength)
						})
				}
			)
			//end of enqueue card 4
		);


		//add items to the queue------------------------------------------------------------------------------------------------------------------------
		//CARD 5----------------------------------------------------------------------------------------------------------------------------------------
		//WIZARD PROTEST--------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Wizard Protest",
				"The Local Wizard is fed up with his living conditions and decides to threaten your settlement until it improves.",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - You offer the Wizard better living conditions by renovating his tower(10).",
					"He appreciates the offer and at the expense of a few resources, he makes peace.",
					"The wizard claims your efforts are too late, and takes resources by force",
					//win effect,
					GlobalsScript.Traits.Trust,
					10,
					new Effect[]{
						new Effect(2, GlobalsScript.Traits.Trust),
						new Effect(-1, GlobalsScript.Resources.Stone),
						new Effect(-1, GlobalsScript.Resources.Food)
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Traits.Strength),
						new Effect(-1, GlobalsScript.Traits.Agility),
						new Effect(-1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Resources.Stone)
					}
				),

					//choice 2
					new CardChoice ("AGILITY - You attempt to stop the wizard before he can do any damage(12)",
						"You sneak past the wizard and knock him out",
						"The wizard blows up your village",
						GlobalsScript.Traits.Agility,
						12,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Agility),
							new Effect(-1, GlobalsScript.Traits.Strength)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Strength),
							new Effect(-1, GlobalsScript.Traits.Agility)
						}

					),

					//choice 3
					new CardChoice ("NOTORIETY - You attempt to intimidate the Wizard into rescinding his attack.(15)",
						"The Wizard is no match for you, as you outlevel him significantly.  He begs for forgiveness.",
						"You get ganked by the Wizard and look foolish.",
						GlobalsScript.Traits.Notoriety,
						15,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Strength),
							new Effect(1, GlobalsScript.Traits.Notoriety)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(-1, GlobalsScript.Traits.Strength),
							new Effect(-1, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 5
		);

		//add items to the queue------------------------------------------------------------------------------------------------------------------------
		//CARD 6----------------------------------------------------------------------------------------------------------------------------------------
		//THRILL OF THE HUNT----------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Thrill of the Hunt",
				"A vicious hunter begins to stalk and hunt your settlement for sport!",

				//choice 1
				new CardChoice[] {new CardChoice ("NOTORIETY - You attempt to use your reputation to scare off the predatory hunter(14).",
					"The hunter decides the thrill of the sport is not worth his own life.",
					"The hunter loves it when his prey puts up a fight and insteads turns up the pressure.",
					//win effect,
					GlobalsScript.Traits.Notoriety,
					14,
					new Effect[]{
						new Effect(3, GlobalsScript.Traits.Notoriety),
						new Effect(1, GlobalsScript.Traits.Strength),
						new Effect(1, GlobalsScript.Traits.Agility)
					},
					//lose effects
					new Effect[]{
						new Effect(-3, GlobalsScript.Resources.People),
						new Effect(-1, GlobalsScript.Traits.Strength),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("Trust - You attempt to convince the hunter that you are not a worthwhile target and instead can supply him.(10)",
						"The hunter agrees, trading some resources for the ones he requires.",
						"The hunter isn't phased by politics, and instead takes resources by force, killing some of your people in the process.",
						GlobalsScript.Traits.Trust,
						10,
						//win effect
						new Effect[]{ 
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Stone),
							new Effect(-1, GlobalsScript.Resources.Food)
						},
						//lose effect
						new Effect[]{
							new Effect(-2, GlobalsScript.Resources.Food),
							new Effect(-2, GlobalsScript.Resources.People)
						}

					),

					//choice 3
					new CardChoice ("STRENGTH - You attempt to hunt the hunter, engaging in a deadly bloodsport.(12)",
						"The hunter becomes the prey and your settlement eliminates him and takes his resources.",
						"You fight a hard battle, but lose settlers in the process.",
						GlobalsScript.Traits.Strength,
						12,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Resources.Food),
							new Effect(2, GlobalsScript.Traits.Notoriety)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
							new Effect(-1, GlobalsScript.Resources.Wood),
							new Effect(-1, GlobalsScript.Resources.Stone)
						})
				}
			)
			//end of enqueue card 6
		);


		//add items to the queue------------------------------------------------------------------------------------------------------------------------
		//CARD 7----------------------------------------------------------------------------------------------------------------------------------------
		//WILDFIRE--------------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Wildfire",
				"Your Settlement finds itself in the path of a raging wildfire!",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You attempt to abandon your current settlement with your villagers taking anything you can carry.",
					"You manage to escape, losing no resources but gaining some survival rank.",
					"You fail to evacuate in time, and while no one is injured, your resources are burnt in the blaze.",
					//win effect,
					GlobalsScript.Traits.Agility,
					10,
					new Effect[]{
						new Effect(1, GlobalsScript.Traits.Survival),
					},
					//lose effects
					new Effect[]{
						new Effect(-2, GlobalsScript.Resources.Wood),
						new Effect(-2, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("SURVIVAL - You attempt to dig fire trenches between the fire and your village to contain the fire.(12)",
						"The trench works and your settlement is spared and the new ditch serves as a new infrastructure to irrigate future crops.",
						"The trench was not complete in time and your village is partially scorched.",
						GlobalsScript.Traits.Survival,
						12,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.Food),
							new Effect(1, GlobalsScript.Traits.Strength)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Resources.Wood),
							new Effect(-1, GlobalsScript.Resources.Food)
						}
					),

					//choice 3
					new CardChoice ("STRENGTH - You take some villagers to attempt to extinguish the fire before it reaches the village.(13)",
						"Your efforts save the village and you gain some food and wood in the scramble.",
						"You lose not only a hefty portion of your village, but a large number of villagers",
						GlobalsScript.Traits.Strength,
						13,
						//win effects
						new Effect[]{
							new Effect(2, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Food)	
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
							new Effect(-2, GlobalsScript.Resources.Wood),
							new Effect(-2, GlobalsScript.Resources.Food),
							new Effect(-1, GlobalsScript.Traits.Survival)
						})
				}
			)
			//end of enqueue card 7
		);

		//add eighth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 8----------------------------------------------------------------------------------------------------------------------------------------
		//Traders arrive------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Traders",
				"A caravan arrives, offering goods to your village.",

				//choice 1
				new CardChoice[] {new CardChoice ("TRUST - You negotiate with the traders for a good deal(8)",
					"Your bargaining pays off, giving some food for supplies",
					"You didn't convince them, but still get something for your food",
					//win effect,
					GlobalsScript.Traits.Trust,
					8,
					new Effect[]{
						new Effect(2, GlobalsScript.Resources.Wood),
						new Effect (1, GlobalsScript.Resources.Stone),
						new Effect (-3, GlobalsScript.Resources.Food),
					},
					//lose effects
					new Effect[]{
						new Effect(1, GlobalsScript.Resources.Wood),
						new Effect(-1, GlobalsScript.Resources.Food)}
				),

					//choice 2
					new CardChoice ("STRENGTH - You show power and try to convince the caravan they need you(10)",
						"In a marvellous display, you convince them",
						"Failing to lift anything, they laugh at you",
						GlobalsScript.Traits.Strength,
						14,
						//win effect
						new Effect[]{ 
							new Effect(1, GlobalsScript.Traits.Strength),
							new Effect(1, GlobalsScript.Traits.Trust)
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Traits.Strength)}

					),

					//choice 3
					new CardChoice ("AGILITY - You attempt to steal from the traders(8)",
						"You succeed, grabbing supplies",
						"They spot you, making sure others know you are not to be trusted",
						GlobalsScript.Traits.Survival,
						10,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Resources.Food),
							new Effect(1, GlobalsScript.Resources.People),
							new Effect(1, GlobalsScript.Resources.Stone)
						},
						//lose effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Traits.Notoriety)
						})


				}
			)
			//end of enqueue card 8
		);

		//add ninth card------------------------------------------------------------------------------------------------------------------------
		//CARD 9--------------------------------------------------------------------------------------------------------------------------------
		//Poachers------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Poachers",
				"Poachers begin hunting prey on your land",

				//choice 1
				new CardChoice[] {new CardChoice ("NOTORIETY - You attempt to scare them away",
					"The hunters run in fears",
					"You aren't more scary than they are hungry",
					//win effect,
					GlobalsScript.Traits.Notoriety,
					8,
					new Effect[]{
						new Effect (1, GlobalsScript.Resources.Food),
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("TRUST - You attempt to set up a deal(9)",
						"The poachers agree to your terms",
						"You attempt reason, but the poachers are too savage and attack",
						GlobalsScript.Traits.Strength,
						14,
						//win effect
						new Effect[]{ 
							new Effect(-1, GlobalsScript.Resources.Food),
							new Effect(-1, GlobalsScript.Traits.Notoriety),
							new Effect(1, GlobalsScript.Resources.Wood),
							new Effect(1, GlobalsScript.Traits.Trust),
						},
						//lose effect
						new Effect[]{
							new Effect(-1, GlobalsScript.Resources.People)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You attack to remove them all(10)",
						"With the hunters dead, you take their resources",
						"You aren't as skilled as you think, and they kill your party",
						GlobalsScript.Traits.Survival,
						10,
						//win effects
						new Effect[]{
							new Effect (2, GlobalsScript.Resources.Food),
							new Effect (1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People),
						})


				}
			)
			//end of enqueue card 9
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 10--------------------------------------------------------------------------------------------------------------------------------------
		//A Raiding Party------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Raid",
				"A raiding party attacks your camp",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You evacuate the camp(10)",
					"You succeed, but gain nothing in the process",
					"You are not fast enough and are attacked",
					//win effect,
					GlobalsScript.Traits.Agility,
					0,
					new Effect[]{
						
					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("NOTORIETY - Your people are fierce and attempt to show them that",
						"You scare away the raiders and even convince some to join",
						"The raiders aren't scared, and show you that",
						GlobalsScript.Traits.Notoriety,
						11,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.People),
							new Effect (-1, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You lay an ambush for the raiders(12)",
						"Your ambush was successful, obliterating the raiding party",
						"They see you coming, leading to a blood bath",
						GlobalsScript.Traits.Survival,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 9
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 11--------------------------------------------------------------------------------------------------------------------------------------
		//A Raiding Party------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Raid",
				"A raiding party attacks your camp",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You evacuate the camp(10)",
					"You succeed, but gain nothing in the process",
					"You are not fast enough and are attacked",
					//win effect,
					GlobalsScript.Traits.Agility,
					0,
					new Effect[]{

					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("NOTORIETY - Your people are fierce and attempt to show them that",
						"You scare away the raiders and even convince some to join",
						"The raiders aren't scared, and show you that",
						GlobalsScript.Traits.Notoriety,
						11,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.People),
							new Effect (-1, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You lay an ambush for the raiders(12)",
						"Your ambush was successful, obliterating the raiding party",
						"They see you coming, leading to a blood bath",
						GlobalsScript.Traits.Survival,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 9
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 12--------------------------------------------------------------------------------------------------------------------------------------
		//A Raiding Party------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Raid",
				"A raiding party attacks your camp",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You evacuate the camp(10)",
					"You succeed, but gain nothing in the process",
					"You are not fast enough and are attacked",
					//win effect,
					GlobalsScript.Traits.Agility,
					0,
					new Effect[]{

					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("NOTORIETY - Your people are fierce and attempt to show them that",
						"You scare away the raiders and even convince some to join",
						"The raiders aren't scared, and show you that",
						GlobalsScript.Traits.Notoriety,
						11,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.People),
							new Effect (-1, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You lay an ambush for the raiders(12)",
						"Your ambush was successful, obliterating the raiding party",
						"They see you coming, leading to a blood bath",
						GlobalsScript.Traits.Survival,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 9
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 13--------------------------------------------------------------------------------------------------------------------------------------
		//A Raiding Party------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Raid",
				"A raiding party attacks your camp",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You evacuate the camp(10)",
					"You succeed, but gain nothing in the process",
					"You are not fast enough and are attacked",
					//win effect,
					GlobalsScript.Traits.Agility,
					0,
					new Effect[]{

					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("NOTORIETY - Your people are fierce and attempt to show them that",
						"You scare away the raiders and even convince some to join",
						"The raiders aren't scared, and show you that",
						GlobalsScript.Traits.Notoriety,
						11,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.People),
							new Effect (-1, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You lay an ambush for the raiders(12)",
						"Your ambush was successful, obliterating the raiding party",
						"They see you coming, leading to a blood bath",
						GlobalsScript.Traits.Survival,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 9
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 14--------------------------------------------------------------------------------------------------------------------------------------
		//A Raiding Party------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Raid",
				"A raiding party attacks your camp",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You evacuate the camp(10)",
					"You succeed, but gain nothing in the process",
					"You are not fast enough and are attacked",
					//win effect,
					GlobalsScript.Traits.Agility,
					0,
					new Effect[]{

					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("NOTORIETY - Your people are fierce and attempt to show them that",
						"You scare away the raiders and even convince some to join",
						"The raiders aren't scared, and show you that",
						GlobalsScript.Traits.Notoriety,
						11,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.People),
							new Effect (-1, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You lay an ambush for the raiders(12)",
						"Your ambush was successful, obliterating the raiding party",
						"They see you coming, leading to a blood bath",
						GlobalsScript.Traits.Survival,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 9
		);

		//add tenth card-------------------------------------------------------------------------------------------------------------------------------
		//CARD 15--------------------------------------------------------------------------------------------------------------------------------------
		//A Raiding Party------------------------------------------------------------------------------------------------------------------------------
		deck.Enqueue (
			//new card one
			new Card ("Raid",
				"A raiding party attacks your camp",

				//choice 1
				new CardChoice[] {new CardChoice ("AGILITY - You evacuate the camp(10)",
					"You succeed, but gain nothing in the process",
					"You are not fast enough and are attacked",
					//win effect,
					GlobalsScript.Traits.Agility,
					0,
					new Effect[]{

					},
					//lose effects
					new Effect[]{
						new Effect(-1, GlobalsScript.Resources.Food),
						new Effect(-1, GlobalsScript.Traits.Notoriety)}
				),

					//choice 2
					new CardChoice ("NOTORIETY - Your people are fierce and attempt to show them that",
						"You scare away the raiders and even convince some to join",
						"The raiders aren't scared, and show you that",
						GlobalsScript.Traits.Notoriety,
						11,
						//win effect
						new Effect[]{ 
							new Effect(2, GlobalsScript.Resources.People)
						},
						//lose effect
						new Effect[]{
							new Effect (-1, GlobalsScript.Resources.People),
							new Effect (-1, GlobalsScript.Resources.Food)}

					),

					//choice 3
					new CardChoice ("SURVIVAL - You lay an ambush for the raiders(12)",
						"Your ambush was successful, obliterating the raiding party",
						"They see you coming, leading to a blood bath",
						GlobalsScript.Traits.Survival,
						12,
						//win effects
						new Effect[]{
							new Effect(1, GlobalsScript.Traits.Notoriety)
						},
						//lose effect
						new Effect[]{ 
							new Effect(-2, GlobalsScript.Resources.People)
						})
				}
			)
			//end of enqueue card 9
		);

	}

	//removed card from the deck
	public Card Dequeue()
	{
		//dequeue the card from the top of the deck
		return deck.Dequeue ();
	}

    public void DrawCard()
    {
        Instantiate(cardPrefab, FindObjectOfType<Canvas>().transform);
        
    }

}
