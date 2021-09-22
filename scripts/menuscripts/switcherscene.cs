using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switcherscene : MonoBehaviour
{
    public void playGame() 
   {
       SceneManager.LoadScene("LevelSelect");
   }
   
    public void help()
   {
        SceneManager.LoadScene("Help");
   }

     public void Quit ()
   {
       Application.Quit();
   }

    public void back()
    {
       SceneManager.LoadScene("Start"); 
    }
    
    public void reload()
    {
       SceneManager.LoadScene("Scene game") ;
    }
}
