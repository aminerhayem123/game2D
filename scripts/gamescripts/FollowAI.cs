 using UnityEngine;
 using System.Collections;
  

 public class FollowAI : MonoBehaviour
 {
      //the enemy's target
     public float Speed ;
     private Transform Player; //move speed
    private Animator animvar;

     void Start()
     {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
     }

     void Update()
     {
         transform.position = Vector2.MoveTowards(this.transform.position,Player.position,Speed * Time.deltaTime);
         
          if (transform.position.x > Player.position.x)
            {
                transform.localScale = new Vector2(3, 3);
            }
            else if (transform.position.x < Player.position.x)
            {
                transform.localScale = new Vector2(-3, 3);
            }
             
     }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        Destroy(gameObject);
       Destroy (GameObject.FindWithTag("Bullet"));
    }
 }