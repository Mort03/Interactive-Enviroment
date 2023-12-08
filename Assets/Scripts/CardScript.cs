using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public GameObject card1Pair1;
    public GameObject card2Pair1;
    public GameObject card1Pair2;
    public GameObject card2Pair2;

    List<GameObject> cardDeck = new List<GameObject>();

    List<Vector3> markLocation = new List<Vector3>();

    List<int> rndNumList = new List<int>();

    //This will be used to count the cards flipped over
    int cardFlips = 0;

    //This will help the player see the card before flipping back the card
    int cardTimer = 0;

    bool cardPair1 = false;
    bool cardPair2 = false;
    //bool cardPair3 = false; if i want it to be harder

    IndividualCardScript oneCard;
    CardWinObjectScript victoryText;

    void Start()
    {
        victoryText = GetComponent<CardWinObjectScript>();
        oneCard = GetComponent<IndividualCardScript>();

        cardDeck.Add(card1Pair1);
        cardDeck.Add(card2Pair1);
        cardDeck.Add(card1Pair2);
        cardDeck.Add(card2Pair2);

        
        markLocation.Add(new Vector3( -15f, 4.02f, 6.2f));
        markLocation.Add(new Vector3(-16.24f, 4.02f, 6.2f));
        markLocation.Add(new Vector3( -13.76f, 4.02f, 6.2f));
        markLocation.Add(new Vector3( -12.62f, 4.02f, 6.2f));


        //This for and while loop does not work
        //Add 4 randomized numbers into the list, because of this for-loop
        for (int i = 0; i <= 5; i++)
        {
            //While the same number exist in the "random number list", it will constantly randomize the number
            //until the numbers are different
            //The code does not work and was supposed to be "while (!rndNumList.Contains(i))" but i could not start the game, i'm only loading when testing
            while (rndNumList.Contains(i))
            {
                rndNumList.Add(Random.Range(0, 4));
            }
            Debug.Log("For loop fungerar");
        }

        //This for loop was supposed to give the cards in cardDeck each a place in the world, but it would not make them move to that position
        //The for loop does work but not the code inside
        for (int i = 0; i <= 5; i++)
        {
            //For some reason this does not work, even when i change to make it look more like my "DoorScript"
            //because that script works, it makes the objects move, this code does not
            cardDeck[i].transform.localPosition = markLocation[rndNumList[i]];
        }
    }
    
    public void ResetFlip()
    {
        cardFlips = 0;
        cardTimer = 0;

        //This will activate by a line of code in "IndividualCardScript"
        //Also this line of code under is making alot of console errors
        //oneCard.renderFalse();

    }

    //This will activate by a line of code in "IndividualCardScript"
    public void CardUp()
    {
        cardFlips++;
    }

    //This will activate by a line of code in "ShuffleScript"
    public void ShuffleCards()
    {
        //This will activate a seperate function and this, because of the code that needs to activate
        ResetFlip();

        cardPair1 = false;
        cardPair2 = false;

        victoryText.ShuffleRemoveText();

        //Ser till att alla nummer i rndNumList går bort innan man lägger till nya
        for (int i = 0; i <= 5; i++)
        {
            rndNumList.Remove(i);
        }
        
        for (int i = 0; i <= 5; i++)
        {
            //While the same number exist in the "random number list", it will constantly randomize the number
            //until the numbers are different
            while (rndNumList.Contains(i))
            {
                rndNumList.Add(Random.Range(0, 3));
            }
        }
        
        for (int i = 0; i <= 5; i++)
        {
            cardDeck[i].transform.localPosition = markLocation[rndNumList[i]];
        }
    }
    
    void FixedUpdate()
    {
        //This code is supposed to check for both renderers of the first pair to be true, but wont make any connections for some reason
        //But the debug wont give me a signal, i know that it's supposed to only check, but i have not reach a solution for this
        if (card1Pair1.GetComponent<Renderer>().enabled == true && card2Pair1.GetComponent<Renderer>().enabled == true && cardPair1 == false)
        {
            cardPair1 = true;
            //Debug.Log("pair1 activated");
        }
        if (card1Pair2.GetComponent<Renderer>().enabled == true && card2Pair2.GetComponent<Renderer>().enabled == true && cardPair2 == false)
        {
            cardPair2 = true;
        }

        //This code works, but the ResetFlip does not
        if (cardFlips > 2 || cardTimer >= 200)
        {
            ResetFlip();
        }
        else if (cardFlips == 2)
        {
            cardTimer++;
        }

        if (cardPair1 == true && cardPair2 == true)
        {
            victoryText.YouWonCardGame();
        }
        if (cardPair1 == true)
        {
            card1Pair1.GetComponent<Renderer>().enabled = true;
            card2Pair1.GetComponent<Renderer>().enabled = true;
        }
        if (cardPair2 == true)
        {
            card1Pair2.GetComponent<Renderer>().enabled = true;
            card2Pair2.GetComponent<Renderer>().enabled = true;
        }
        
    }   
}
