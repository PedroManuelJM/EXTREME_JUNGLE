using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    // Start is called before the first frame update
    public float mover;
    void Start()
    {
        
    }
    public void Init(float x, float y)
    {
      transform.position= new Vector2(x,y);
 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	if((transform.position.x > 7.4f) || (transform.position.x < -6.54f)){
           mover =  mover*(-1);
        }
        GetComponent<SpriteRenderer>().flipX= mover > 0 ? true : false;
        GetComponent<Rigidbody2D>().velocity =
        new Vector2(mover,GetComponent<Rigidbody2D>().velocity.y);
        
    }
}
