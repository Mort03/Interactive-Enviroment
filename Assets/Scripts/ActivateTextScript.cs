using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActivateTextScript : MonoBehaviour
{
    public TMP_Text PressYForText;

    private string showText1 = "Press Y for information";
    private string showText2 = "The stuff to the left of the picture does not work, it's supposed to be the card game";

    bool check = false;

    void Start()
    {
        PressYForText.text = showText1;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Y) && check == false)
        {
            PressYForText.text = showText2;
            check = true;
        } 
            else if (Input.GetKey(KeyCode.Y) && check == true)
        {
            PressYForText.text = showText1;
            check = false;
        }
    }

}
