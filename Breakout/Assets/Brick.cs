using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

//OnCollision to destroy the brick if the ball collides with it 
    private void OnCollisionEnter2D(Collision2D collision)  
    {       
        if(collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().P1Score();
            

        }
        
    }
}
