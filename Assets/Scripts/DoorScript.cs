using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class DoorScript : MonoBehaviour
{
    public Transform DoorClosed;
    public Transform DoorOpen;

    bool doorClosed = true;
    bool doorOpen = false;

    public void OnInteraction()
    {
        if (doorClosed == true)
        {
            DoorClosed.position = new Vector3( 0, -5, 10);
            DoorOpen.position = new Vector3(-1.75f, 1, 8.25f);
            Debug.Log("doorClosed is true works");
            doorClosed = false;
            doorOpen = true;
        } else if (doorOpen == true)
        {
            DoorClosed.position = new Vector3(0, 1, 10);
            DoorOpen.position = new Vector3(-1.75f, -5, -8.25f);
            Debug.Log("doorOpen is true works");
            doorClosed = true;
            doorOpen = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
