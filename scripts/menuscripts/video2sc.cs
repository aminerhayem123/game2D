using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
 
public class video2sc : MonoBehaviour {
public VideoPlayer vid;
 
 
void Start(){vid.loopPointReached += CheckOver;}
 
void CheckOver(UnityEngine.Video.VideoPlayer vp)
{
    SceneManager.LoadScene("QuizLevel2");
}
 
}
