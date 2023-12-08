using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleScript : MonoBehaviour
{
    CardScript shuffle; 

    // Start is called before the first frame update
    void Start()
    {
        shuffle = GetComponent<CardScript>();
    }

    //This will activate by a line of code in "CardScript"
    public void OnMouseDown()
    {
        shuffle.ShuffleCards();
    }
}
