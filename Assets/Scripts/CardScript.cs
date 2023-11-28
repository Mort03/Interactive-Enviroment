using System.Collections;
using System.Collections.Generic;
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

    void Start()
    {
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
            while (!rndNumList.Contains(i))
            {
                rndNumList.Add(Random.Range(0, 3));
            }
        }

        for (int i = 0; i < cardDeck.Count; i++)
        {
            cardDeck[i].GetComponent<Renderer>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        
        
    }

    void Update()
    {
        for (int i = 0; i < rndNumList.Count; i++)
        {
            rndNumList 
        }
    }
}
