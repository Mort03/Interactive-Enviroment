using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
    //Switches the scene to "Tutorial"
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Tutorial");
    }

}
