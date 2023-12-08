using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    //Switches the scene to "World"
    private void OnMouseDown()
    {
        SceneManager.LoadScene("World");
    }

}
