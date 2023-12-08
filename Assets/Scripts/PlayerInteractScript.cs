using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 5f);

            Debug.DrawRay(transform.position, transform.forward, Color.red, 1);

            if (hit == true)
            {
                
                DoorScript interactable;
                hitInfo.transform.TryGetComponent<DoorScript> (out interactable);
                

                if (interactable != null)
                {
                    interactable.OnInteraction();
                    //Debug.Log("If-satsen funkar");
                }
                else
                {
                    Debug.Log("Not interactable");
                }
            }
        }
    }
}
