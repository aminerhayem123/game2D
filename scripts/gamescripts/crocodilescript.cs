using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crocodilescript : MonoBehaviour
{
    static bool right;

    void Update()
    {
        if (right == true)
        {
        SceneManager.LoadScene("video");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
     right = true;          
    }

     void OnTriggerExit2D(Collider2D other)
     {
     right = false;
     }
}
