using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma2 : MonoBehaviour
{
	public float move;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   public void Init(float x , float y){
    	transform.position = new Vector2(x,y);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if ((transform.position.y > 1f) || (transform.position.y < -3.9f))
       {
       	move = move*(-1);
       }

       GetComponent<Rigidbody2D>().velocity =
       new Vector2(GetComponent<Rigidbody2D>().velocity.x,move);
    }
    
}
