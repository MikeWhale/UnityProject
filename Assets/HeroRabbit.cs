using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRabbit : MonoBehaviour 
{
    public float speed = 10;
    Rigidbody2D myBody = null;

    void Start () 
    {
        myBody = this.GetComponent<Rigidbody2D> ();
		
	}

    void Update () 
    {
        float value = Input.GetAxis ("Horizontal");
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        
        if (Mathf.Abs (value) > 0) 
        {
        Vector2 vel = myBody.velocity;
        vel.x = value * speed;
        myBody.velocity = vel;
        }
                     
        if(value < 0) 
         {
            sr.flipX = true;
         } 
        else if(value > 0) 
         {
            sr.flipX = false;
         }
    }
}
