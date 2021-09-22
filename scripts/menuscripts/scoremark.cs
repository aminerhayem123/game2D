using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremark : MonoBehaviour
{
   public Text textBox;
    void Start()
    {
          textBox.text = quiz.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
