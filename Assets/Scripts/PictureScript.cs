using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class PictureScript : MonoBehaviour
{
    public Transform picture1;
    public Transform picture2;
    public Transform picture3;

    bool P1 = true;
    bool P2 = false;
    bool P3 = false;

    public void OnMouseDown()
    {
        if (P1 == true)
        {
            picture1.position = new Vector3(-8f, -2f, 9.05f);
            picture2.position = new Vector3(-8f, 1.5f, 9.05f);
            picture3.position = new Vector3(-8f, -2f, 9.05f);

            P1 = false;
            P2 = true;
            P3 = false;
        }
        else if (P2 == true)
        {
            picture1.position = new Vector3(-8f, -2f, 9.05f);
            picture2.position = new Vector3(-8f, -2f, 9.05f);
            picture3.position = new Vector3(-8f, 1.5f, 9.05f);


            P1 = false;
            P2 = false;
            P3 = true;
        }
        else if (P3 == true)
        {
            picture1.position = new Vector3(-8f, 1.5f, 9.05f);
            picture2.position = new Vector3(-8f, -2f, 9.05f);
            picture3.position = new Vector3(-8f, -2f, 9.05f);


            P1 = true;
            P2 = false;
            P3 = false;
        }
    }
}
