using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObjectScript : MonoBehaviour
{
    public GameObject selectedObject;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            TrySelectObject();
        }

        //This code makes the selected object get bigger
        if (Input.GetKeyDown(KeyCode.F) && selectedObject != null)
        {
            selectedObject.transform.localScale *= 1.1f;
        }
    }

    void TrySelectObject()
    {
        RaycastHit hitInfo = new RaycastHit();

        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit)
        {
            selectedObject = hitInfo.transform.gameObject;
            Debug.Log("Can hit object");
        }
        else
        {
            selectedObject = null;
            Debug.Log("Can not hit object");
        }
    }
}
