using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timeclock : MonoBehaviour
{
   public float timeStart = 30;
   public Text textBox;
   public GameObject text;
   float timer=3f;

    void Start()
    {
      textBox.text= timeStart.ToString() ;
    }

    // Update is called once per frame
    void Update()
    {
          if (timeStart > 0)
          {
             timeStart -= Time.deltaTime;
             textBox.text = Mathf.Round(timeStart).ToString();
          }  
          else if (timeStart <= 0 && SceneManager.GetActiveScene().name != "Quiz5")
          {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
          }
          
          if (quiz.answer == false &&timeStart <= 0 && SceneManager.GetActiveScene().name == "Quiz5")
          {
             text.SetActive(true);

              timer -=Time.deltaTime;
              if (quiz.score >= 300 && timer <= 0)
            {
                SceneManager.LoadScene("you win");
            }
            else if (quiz.score <= 300 && timer <= 0 )
            {
                SceneManager.LoadScene("GameOver");
            }
          }
    }
}
