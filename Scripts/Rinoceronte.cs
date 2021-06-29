using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rinoceronte : MonoBehaviour
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
    {
         if((transform.position.x > 6f) || (transform.position.x < -4.49f)){
           mover =  mover*(-1);
        }
        GetComponent<SpriteRenderer>().flipX= mover < 0 ? true : false;
        GetComponent<Rigidbody2D>().velocity =
        new Vector2(mover,GetComponent<Rigidbody2D>().velocity.y);
    }
}
