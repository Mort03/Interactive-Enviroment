using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorToStartScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("Start Menu");
        }
    }
}
