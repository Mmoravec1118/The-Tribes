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

        GlobalsScript.Traits currTrait;

        GlobalsScript globals;
        MenuButtonScript menu;

        public GameObject toolTipPrefab;

        // reference to die roller
        DieScript die;

        bool win;
        // reference to current player
        PlayerClass currPlayer;
        public CardChoice[] choices { get; set; }

        public void Start()
        {
            card = MonoBehaviour.FindObjectOfType<Deck>().Dequeue();
            titleMesh.text = card.title;
            descriptionMesh.text = card.description;
            choices = card.choices;
            option1.text = card.choices[0].Description;
            option2.text = card.choices[1].Description;
            option3.text = card.choices[2].Description;
        }

        // first button of card
        public void CardChoice1()
        {
            // get references to all necessary objects
            globals = MonoBehaviour.FindObjectOfType<GlobalsScript>();
            die = MonoBehaviour.FindObjectOfType<DieScript>().GetComponent<DieScript>();
            currPlayer = globals.GetPlayer();
            menu = MonoBehaviour.FindObjectOfType<MenuButtonScript>();

            win = choices[0].CheckResult();
           // StartCoroutine(ShowInfoTimer());
            if (win)
            {
                foreach (Effect effect in card.choices[0].winEffects)
                {
                    effect.ApplyEffect();
                }
                //currPlayer.Strength++;
                die.NeedsRoll = true;
                globals.PlayerTurn += 1;
               // menu.exitDrawCardPhase();
            }
            else
            {
                foreach (Effect effect in card.choices[0].lossEffects)
                {
                    effect.ApplyEffect();
                }
                //currPlayer.Wood--;
                die.NeedsRoll = true;
                globals.PlayerTurn += 1;
            }
            Invoke("exitMenuPhase", 5);
        }

        // second button on card
        public void CardChoice2()
        {
            // get references to all necessary objects
            globals = MonoBehaviour.FindObjectOfType<GlobalsScript>();
            die = MonoBehaviour.FindObjectOfType<DieScript>().GetComponent<DieScript>();
            currPlayer = globals.GetPlayer();
            menu = MonoBehaviour.FindObjectOfType<MenuButtonScript>();

            win = card.choices[1].CheckResult();
            if (win)
            {
                foreach (Effect effect in card.choices[1].winEffects)
                {
                    effect.ApplyEffect();
                }
                //currPlayer.Trust++;
                die.NeedsRoll = true;
                globals.PlayerTurn += 1;
            }
            else
            {
                foreach (Effect effect in card.choices[1].lossEffects)
                {
                    effect.ApplyEffect();
                }
                //currPlayer.Food--;
                die.NeedsRoll = true;
                globals.PlayerTurn += 1;
            }
            Invoke("exitMenuPhase", 5);
        }

        // third button on card
        public void CardChoice3()
        {
            // get references to all necessary objects
            globals = MonoBehaviour.FindObjectOfType<GlobalsScript>();
            die = MonoBehaviour.FindObjectOfType<DieScript>().GetComponent<DieScript>();
            currPlayer = globals.GetPlayer();

            win = card.choices[2].CheckResult();
            if (win)
            {
                foreach (Effect effect in card.choices[2].winEffects)
                {
                    effect.ApplyEffect();
                }
                //currPlayer.Notoriety++;
                die.NeedsRoll = true;
                globals.PlayerTurn += 1;
            }
            else
            {
                foreach (Effect effect in card.choices[2].lossEffects)
                {
                    effect.ApplyEffect();
                }
                //currPlayer.People--;
                die.NeedsRoll = true;
                globals.PlayerTurn += 1;
            }
            Invoke("exitMenuPhase", 5);
        }

        public void exitMenuPhase()
        {
           menu = MonoBehaviour.FindObjectOfType<MenuButtonScript>();
            menu.exitDrawCardPhase();
        }

        // checks result of player stats + die result against card cost
        //void CheckResult()
        //{
        //    if (!die.NeedsRoll)
        //    {
        //        switch (currTrait)
        //        {
        //            case GlobalsScript.Traits.Strength:
        //                {
        //                    if (currPlayer.Strength + die.DieResult >= cost)
        //                    {
        //                        descriptionMesh.text = card.w winText;
        //                        win = true;
        //                    }
        //                    else
        //                    {
        //                        currCard.descriptionMesh.text = lossText;
        //                        win = false;
        //                    }
        //                    break;
        //                }
        //            case GlobalsScript.Traits.Agility:
        //                {
        //                    if (currPlayer.Agility + die.DieResult >= cost)
        //                    {
        //                        currCard.descriptionMesh.text = winText;
        //                        win = true;
        //                    }
        //                    else
        //                    {
        //                        currCard.descriptionMesh.text = lossText;
        //                        win = false;
        //                    }
        //                    break;
        //                }
        //            case GlobalsScript.Traits.Trust:
        //                {
        //                    if (currPlayer.Trust + die.DieResult >= cost)
        //                    {
        //                        currCard.descriptionMesh.text = winText;
        //                        win = true;
        //                    }
        //                    else
        //                    {
        //                        currCard.descriptionMesh.text = lossText;
        //                        win = false;
        //                    }
        //                    break;
        //                }
        //            case GlobalsScript.Traits.Notoriety:
        //                {
        //                    if (currPlayer.Notoriety + die.DieResult >= cost)
        //                    {
        //                        currCard.descriptionMesh.text = winText;
        //                        win = true;
        //                    }
        //                    else
        //                    {
        //                        currCard.descriptionMesh.text = lossText;
        //                        win = false;
        //                    }
        //                    break;
        //                }
        //            case GlobalsScript.Traits.Survival:
        //                {
        //                    if (currPlayer.Survival + die.DieResult >= cost)
        //                    {
        //                        currCard.descriptionMesh.text = winText;
        //                        win = true;
        //                    }
        //                    else
        //                    {
        //                        currCard.descriptionMesh.text = lossText;
        //                        win = false;
        //                    }
        //                    break;
        //                }
        //        }
        //    }
        //    else
        //    {
        //        currCard.descriptionMesh.text = "Roll Die and press Button again";

        //    }
        //}
    }
}
