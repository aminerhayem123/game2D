using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.SceneManagement;

public class lvlunlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("levelunlocked",2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void go()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
