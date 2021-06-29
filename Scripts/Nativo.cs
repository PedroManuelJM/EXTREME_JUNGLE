using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nativo : MonoBehaviour
{
    // Start is called before the first frame update
    public float mover;
    private float initX;
    private float finalX;
    private float initY;
    private float finalY;
    private bool direccion; // true : izquierda a derecha o abajo a arriba , false : derecha a izquierda o arriba a abajo
    private bool recta2D; //  true horizontal y false vertical 
    void Start()
    {
        
    }
    public void Init(float x, float y)
    {
      transform.position= new Vector2(x,y);
    }

    public void Init(float initX , float initY, float distancia , bool recta2D , bool direccion){
      this.initX = initX;
      this.initY = initY;
      if(recta2D) this.finalX = this.initX + distancia;
      else this.finalY = this.initY + distancia;
      this.recta2D = recta2D ;
      this.direccion = direccion;
    	transform.position = new Vector2(initX,initY);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Nivel04"){
          Recta2D();
        }else{
          if((transform.position.x > 1.5f) || (transform.position.x < -6.1f)){
          mover =  mover*(-1);
          }
          GetComponent<SpriteRenderer>().flipX= mover < 0 ? true : false;
          GetComponent<Rigidbody2D>().velocity =
          new Vector2(mover,GetComponent<Rigidbody2D>().velocity.y);
        }
    }



    public void Recta2D(){
      if(this.recta2D){
          if(this.direccion){
              if ((transform.position.x < this.initX ) || (transform.position.x > this.finalX )){
                  this.mover = this.mover*(-1);
              }
          }else{
              if ((transform.position.x > this.initX ) || (transform.position.x < this.finalX )){
                  this.mover = this.mover*(-1);
              }
          }
          GetComponent<SpriteRenderer>().flipX= this.mover < 0 ? true : false;
          GetComponent<Rigidbody2D>().velocity =
          new Vector2(this.mover,GetComponent<Rigidbody2D>().velocity.y);
      }else{
          if(this.direccion){
              if ((transform.position.y < this.initY ) || (transform.position.y > this.finalY )){
                  this.mover = this.mover*(-1);
              }
          }else{
              if ((transform.position.y > this.initY ) || (transform.position.y < this.finalY )){
                  this.mover = this.mover*(-1);
              }
          }
          GetComponent<SpriteRenderer>().flipX= this.mover < 0 ? true : false;
          GetComponent<Rigidbody2D>().velocity =
          new Vector2(this.mover,GetComponent<Rigidbody2D>().velocity.y);  
      }
    }
}
