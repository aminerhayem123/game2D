using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeplatform : MonoBehaviour
{
   float timer = 3f;
   bool v = false;

   void Update ()
   {
         if  (v == true)
        {
          timer -=Time.deltaTime;
            if (timer <= 0)
            {
             Destroy (gameObject);
            }   
        }
   }

   void OnCollisionEnter2D(Collision2D col)
   {

   if (col.gameObject.tag == "Player")
			v=true;
   }

   void OnCollisionExit2D(Collision2D col)
   {

   if (col.gameObject.tag == "Player")
			v=false;
   }
}
