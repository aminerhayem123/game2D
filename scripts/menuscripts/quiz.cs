using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quiz : MonoBehaviour
{
     public GameObject text1;
     public GameObject text2;
     bool value=false;
     public static bool answer=false;
     float timer=3f;
     public static float score;

    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (value==true && SceneManager.GetActiveScene().name != "Quiz5")
        {
               timer -=Time.deltaTime;
            if (timer <= 0)
            {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }   
        }
        else if (value==true && SceneManager.GetActiveScene().name == "Quiz5")
        {
            timer -=Time.deltaTime;
            if (score >= 300 && timer <= 0)
            {
                SceneManager.LoadScene("you win");
            }
            else if (score <= 300 && timer <= 0 )
            {
                SceneManager.LoadScene("GameOver");
            }
        }   
    }

    public void correct()
    {
        answer=true;
        score+=100;
        value=true;
       text1.SetActive(true); 
       text2.SetActive(false);
    }

    public void wrong()
    {
        value=true;
       text2.SetActive(true); 
       text1.SetActive(false);
    }
}
