using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cractersounds : MonoBehaviour
{
    public static AudioClip hitsound , jumpsound , diesound , walksound ,gun;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        gun = Resources.Load<AudioClip> ("gun");
        hitsound  = Resources.Load<AudioClip> ("hurt");
        jumpsound = Resources.Load<AudioClip> ("jump");
        diesound = Resources.Load<AudioClip> ("die");
        walksound  = Resources.Load<AudioClip> ("walk");

       audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public  static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "walk":
            audioSrc.PlayOneShot (walksound);
            break;

            case "jump":
            audioSrc.PlayOneShot (jumpsound);
            break;

            case "hurt":
            audioSrc.PlayOneShot (hitsound);
            break;

            case "die" : 
            audioSrc.PlayOneShot (diesound);
            break;

            case "gun" : 
            audioSrc.PlayOneShot (gun);
            break;
        }
    }
}
