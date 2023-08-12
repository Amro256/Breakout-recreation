using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed = 500f; //Variable for ball speed;
    //public float force = 500;
    public Rigidbody2D rb;
    Vector3 startPos; //Vector 3 to store the intial starting position of the ball
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Test();
        //ballSpeed = 20f;
         // Once the game starts a force is added to the ball in it's up direction
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    

   private void OnCollisionEnter2D(Collision2D collision) 
   {
        if(collision.gameObject.CompareTag("Death"))
        {
            //Call respawn method 
            Respawn();
            GameObject.Find("GameManager").GetComponent<GameManager>().RemoveLife();
        }
   }

   void Respawn()  //Method that will respawn the ball when it collides with the killZone
   {
    transform.position = startPos;
     //Sets the position of the ball back to the intial starting position 
    //rb.velocity = Vector2.zero; //Sets the rb velocity to 0 (does not work as indented)
    //Code here so if the player presses a key the ball respawns
    
   }

   //Method to launch ball on start
   void Test()
   {
    Vector2 dir = Vector2.zero;
    dir.x = Random.Range(-1f, 1f);
    dir.y = -1;

    rb.AddForce(dir.normalized * ballSpeed);
   }
   
//Ienumator code so the balls wait a few seconds before spawning in

}
