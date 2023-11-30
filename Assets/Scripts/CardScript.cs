using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    CardWinObjectScript victoryText;

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

    bool victory = false;

    void Start()
    {
        victoryText = GetComponent<CardWinObjectScript>();

        cardDeck.Add(card1Pair1);
        cardDeck.Add(card2Pair1);
        cardDeck.Add(card1Pair2);
        cardDeck.Add(card2Pair2);

        markLocation.Add(new Vector3(3.2f, 4f, 1.3f));
        markLocation.Add(new Vector3(2f, 4f, 1.3f));
        markLocation.Add(new Vector3(0.8f, 4, 1.3f));
        markLocation.Add(new Vector3(-0.4f, 4f, 1.3f));

        
        //Add 4 randomized numbers into the list, because of this for-loop
        for (int i = 0; i <= 5; i++)
        {
            //While the same number exist in the "random number list", it will constantly randomize the number
            //until the numbers are different
            while (rndNumList.Contains(i))
            {
                rndNumList.Add(Random.Range(0, 4));
                Debug.Log("while funkar");
            }
        }
        
        /*
        //All objects in cardDeck gets their renderer enabled to false, meaning they are not visible
        //But still interactable
        for (int i = 0; i < cardDeck.Count; i++)
        {
            cardDeck[i].GetComponent<Renderer>().enabled = true;
        }
        */
        //Objects in cardDeck gets a new position with markLocation
        //markLocation gets a random number make sure the card objects are not easily solved
        for (int i = 0; i <= 5; i++)
        {
            cardDeck[i].transform.localPosition = markLocation[rndNumList[i]];
        }
    }
    
    void ResetFlip()
    {

        cardFlips = 0;
        cardTimer = 0;

        //INSTEAD CALL FOR IT, THIS WONT WORK
        /*
        //When ShuffleCards activates, the renderer of each object is enabled equal to false, making it invisible
        for (int i = 0; i < cardDeck.Count; i++)
        {
            cardDeck[i].GetComponent<Renderer>().enabled = false;
        }
        */
    }


    public void ShuffleCards()
    {
        //This will activate a seperate function and this, because of the code that needs to activate
        ResetFlip();

        cardPair1 = false;
        cardPair2 = false;
        //cardPair3 = false;

        victory = false;

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
        if (card1Pair1 && card2Pair1 == GetComponent<Renderer>().enabled == true && cardPair1 == false)
        {
            cardPair1 = true;
        }
        if (card1Pair2 && card2Pair2 == GetComponent<Renderer>().enabled == true)
        {
            cardPair2 = true;
        }
        if (cardFlips > 2 || cardTimer == 200)
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
            victory = true;
        }

        if (victory == true)
        {
            cardFlips = 0;
            cardTimer = 0;
        }
        if (cardPair1 == true)
        {
            //cardDeck[0].GetComponent<Renderer>().enabled = true;
            //cardDeck[1].GetComponent<Renderer>().enabled = true;
        }
        if (cardPair2 == true)
        {
            //cardDeck[2].GetComponent<Renderer>().enabled = true;
            //cardDeck[3].GetComponent<Renderer>().enabled = true;
        }
    }   
}
