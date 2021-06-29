using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformanivel1 : MonoBehaviour
{
   private int move;
    private float initX;
    private float finalX;
    private float initY;
    private float finalY;
    private bool direccion; // true : izquierda a derecha o abajo a arriba , false : derecha a izquierda o arriba a abajo
    private bool recta2D; //  true horizontal y false vertical 
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Recta2D();
    }

    public void Init(float initX , float initY, float distancia , bool recta2D , bool direccion, int move){
        this.initX = initX;
        this.initY = initY;
        if(recta2D) this.finalX = this.initX + distancia;
        else this.finalY = this.initY + distancia;
        this.move = move;
        this.recta2D = recta2D ;
        this.direccion = direccion;
    	transform.position = new Vector2(initX,initY);
    }

    public void Recta2D(){
        
        if(this.recta2D){
            if(this.direccion){
                if ((transform.position.x < this.initX ) || (transform.position.x > this.finalX )){
                    this.move = this.move*(-1);
                }
            }else{
                if ((transform.position.x > this.initX ) || (transform.position.x < this.finalX )){
                    this.move = this.move*(-1);
                }
            }
            GetComponent<Rigidbody2D>().velocity =
            new Vector2(this.move,GetComponent<Rigidbody2D>().velocity.y);
        }else{
            if(this.direccion){
                if ((transform.position.y < this.initY ) || (transform.position.y > this.finalY )){
                    this.move = this.move*(-1);
                }
            }else{
                if ((transform.position.y > this.initY ) || (transform.position.y < this.finalY )){
                    this.move = this.move*(-1);
                }
            }
            GetComponent<Rigidbody2D>().velocity =
            new Vector2(GetComponent<Rigidbody2D>().velocity.x,this.move);   
                
           
        }
        
    }

}
