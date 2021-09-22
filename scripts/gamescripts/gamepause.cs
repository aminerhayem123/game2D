using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamepause : MonoBehaviour
{

    public static bool isGamePaused = false;
    [SerializeField]  GameObject pauseMenue;
    
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
          if (isGamePaused)
          {
              ResumeGame();
          }
          else
          {
              {
                  pauseGame();
              }
          }
      }
    }
       public void ResumeGame()
       {
           pauseMenue.SetActive(false);
           Time.timeScale=1f;
           isGamePaused=false;
       }

       void pauseGame()
       {
           pauseMenue.SetActive(true);
           Time.timeScale=0f;
           isGamePaused=true;
       }

       public void loadMenue()
       {
         ResumeGame();
         SceneManager.LoadScene("Start");
       }

       public void QuitGame()
       {
         Application.Quit();
       }
}
