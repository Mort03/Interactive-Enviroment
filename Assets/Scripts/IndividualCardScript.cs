using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualCardScript : MonoBehaviour
{
    CardScript cardUp;

    // Start is called before the first frame update
    void Start()
    {
        cardUp = GetComponent<CardScript>();
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void OnMouseDown()
    {
        if (gameObject.GetComponent<Renderer>().enabled == false)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            cardUp.CardUp();
        }
    }
    
    public void renderFalse()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
    
}
