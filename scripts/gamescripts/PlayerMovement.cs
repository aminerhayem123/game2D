using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
     public CharacterController2D controller;
     public Animator animator; 

     public float runSpeed=40f;
     float horizontalMove = 0f;
     float timer =3f;
     bool jump = false;
     bool Saut = false;
     bool hurt = false;
     bool dead = false;
     bool value;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        

        if (Input.GetButtonDown("Jump") && Saut ){
            cractersounds.PlaySound ("jump");
            jump=true;
            animator.SetBool("J", true);
        }

        if (hurt==true){
            animator.SetBool("H", true);
        }
        else
        {
            animator.SetBool("H", false);
        }

        if (dead == true){
            animator.SetBool("D", true); 
        }
        else
        {
            animator.SetBool("D", false);
        }

        if ( (value == true))
        {
          timer -=Time.deltaTime;
            if (timer <= 0)
            {
             SceneManager.LoadScene("GameOver");
            }   
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("J", false);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemie" &&  GameControlScript.health > 0)
        {
            hurt=true;     
            cractersounds.PlaySound ("hurt");
            GameControlScript.health -= 1 ;
        } 

        if (other.gameObject.tag == "animal" &&  GameControlScript.health > 0)
        {
            cractersounds.PlaySound ("hurt");
            hurt=true;     
            GameControlScript.health -= 1 ;
        } 

        if  (other.gameObject.tag == "Respawn" || GameControlScript.health <= 0)     
        {
            cractersounds.PlaySound ("die");
            GameControlScript.health = 0;
            value=true;  
            dead=true;  
        }          
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemie")
        {
            hurt=false;     
        }   

        if (other.gameObject.tag == "animal")
        {
            hurt=false;     
        }   

        if  (other.gameObject.tag == "Respawn")     
        {
            dead=false;
        }         
    }

    void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "sol")
          Saut = true; 
	}

	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.tag == "sol")
			Saut = false;  
	} 

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump=false; 
    }
   
}
