using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
        int levelunlocked;
        public Button[] Buttons;
    
    void Start()
    {
        levelunlocked = PlayerPrefs.GetInt("levelunlocked",1);

        for (int i = 0 ; i < Buttons.Length; i++)
        {
            Buttons[i].interactable = false;
        }
        for (int i = 0 ; i < levelunlocked; i++)
        {
            Buttons[i].interactable = true;
        }
    }
    
    public void loadlevel1(int levelIndex)
        {
        SceneManager.LoadScene(levelIndex);
        }

    public void goback()
    {
        SceneManager.LoadScene("Start");
    }

}
