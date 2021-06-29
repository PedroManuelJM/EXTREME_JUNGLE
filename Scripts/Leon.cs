using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leon : MonoBehaviour
{
	public float mover;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Init (float x,float y){
        transform.position= new Vector2(x,y);
    }
    // Update is called once per frame
    void FixedUpdate()
    { // 8.4             3.84
        if((transform.position.x >10f) || (transform.position.x <3.84f)){
           mover =  mover*(-1);
        }
        GetComponent<SpriteRenderer>().flipX= mover >0 ? true : false;   //true : false
        GetComponent<Rigidbody2D>().velocity =
        new Vector2(mover,GetComponent<Rigidbody2D>().velocity.y);
    }

   /* public void OnTriggerExit2D(Collider2D collider)
    {
     if(collider.tag == "pisoselva")
      {
     	GetComponent<Rigidbody2D>().mass =1;
     	GetComponent<Rigidbody2D>().gravityScale =1;
      }
    } */


}
