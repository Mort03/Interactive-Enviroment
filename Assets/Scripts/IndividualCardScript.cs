using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualCardScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        if (gameObject.GetComponent<Renderer>().enabled == false)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
