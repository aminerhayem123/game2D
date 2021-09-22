using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
     public GameObject dialogbox;
     public Text dialogText;
     public string dialog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
               dialogbox.SetActive(true);
               dialogText.text = dialog;
        }
    }

     private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
           dialogbox.SetActive(false);
        }
    }
    
}
