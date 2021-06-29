using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Rick : MonoBehaviour
{
  //Variables publicas
	public float speed;
  public float speed_max;
	public float jump;
  //Variables Privadas
  private CameraRick camera;
  private Rigidbody2D rbRick;
  private SpriteRenderer srRick;
  private Animator aRick;
  private bool bRicksalta;
  private TextoPantalla textoPantalla;
  public GameObject textoFinal;
  public GameObject textoPerdistes;
  public GameObject sonidoFelicidad;
  public GameObject sonidoPerdistes;
  private bool bandMuerte = true;
    // Start is called before the first frame update
    void Start()
    {
      rbRick=GetComponent<Rigidbody2D>();
      srRick=GetComponent<SpriteRenderer>();
      aRick=GetComponent<Animator>();
      aRick.SetBool("piso",false);
      
       //input = "Rick";

    }

    public void Init(string nivel) //new Vector2(-8.62f,4.53f)
    {
      if(nivel=="Nivel01")
      transform.position = new Vector2(-8.62f,-2.22f);
      if(nivel=="Nivel02")
      transform.position = new Vector2(-8.62f,-3.56f);
      if(nivel=="Nivel03")
      transform.position = new Vector2(-8.89f,2.44f);
      if(nivel=="Nivel04")
      transform.position = new Vector2(-3.46f,-0.49f);
    }

 // se compila con control + b
    // Update is called once per frame
    void Update()
    {     
        textoPantalla = FindObjectOfType<TextoPantalla>();
        aRick.SetFloat("speed", Mathf.Abs(rbRick.velocity.x));

        if(textoPantalla.vidaTexto.text == "0"  && bandMuerte == true){
          camera = FindObjectOfType<CameraRick>();
          Instantiate (textoPerdistes);
          Instantiate (sonidoPerdistes);
          float posX = camera.transform.position.x+5.25f;
          float posY = camera.transform.position.y-1.50f;
          textoPerdistes.transform.position = new Vector3(posX,posY,-4.0f);
          bandMuerte = false;
          Destroy(this);
          Destroy(camera); // primer punto
          Destroy(textoPantalla); // segundo punto
        }
    // si se presion la tecla de la izquierda ( se mueve a la izquierda)
            if(Input.GetKey(KeyCode.LeftArrow)){
            //definiendo el cuerpo del player y dandole la opcion de movimiento
            //hacia izquierda negativo -
              srRick.flipX = true;
              rbRick.velocity = new Vector2(-speed, rbRick.velocity.y);
            
            //definiendo para que mario pueda mirar a la izquierda como a la derecha
            
          }

          if(Input.GetKey(KeyCode.RightArrow)){
            //definiendo el cuerpo del player y dandole la opcion de movimiento
            //hacia derecha positivo
              //definiendo para que mario pueda mirar a la izquierda como a la derecha  
              
                srRick.flipX = false;
                  rbRick.velocity = new Vector2(speed, rbRick.velocity.y);
              
              
          }
        
        
           

    }
//termina el void update
          void FixedUpdate()
          {
            //Para que no exceda el limite de velocidad
            if(rbRick.velocity.magnitude > speed_max)
            {
              rbRick.velocity=rbRick.velocity.normalized *speed_max;
            }
            //Para controlar el salto de Rick
            if(Input.GetAxis("Jump")>0 && aRick.GetBool("piso"))
            {
              aRick.SetBool("piso",false);   
              rbRick.velocity = new Vector2(rbRick.velocity.x,0f);
              rbRick.AddForce(new Vector2(0f,jump),ForceMode2D.Impulse); 
            }
          }//fin de fixedUpdate


      public void OnCollisionEnter2D(Collision2D collision){

          if(collision.gameObject.tag == "agua")
          {
            Debug.Log("Rick muere ahogado");
            textoPantalla.vidaTexto.text  = "" + (int.Parse(textoPantalla.vidaTexto.text) - 1) ;
            Init(SceneManager.GetActiveScene().name);
            
          }
          // pase a nivel 2
          if(collision.gameObject.tag=="casaNivel01")
          {
            textoPantalla.scoreTexto.text  = "" +  (int.Parse(textoPantalla.scoreTexto.text) + int.Parse(textoPantalla.tiempoTexto.text)) ;
            Debug.Log("Rick paso nivel 2!");
            textoPantalla.tiempo = 80.0f;
            SceneManager.LoadScene(2);
              
          }
          //pase a nivel 3
         if(collision.gameObject.tag == "casaNivel02")
          {
             //nivel 3
            textoPantalla.scoreTexto.text  = "" + (int.Parse(textoPantalla.scoreTexto.text) + int.Parse(textoPantalla.tiempoTexto.text)) ;
            Debug.Log("Rick paso nivel 3!");
            textoPantalla.tiempo = 80.0f;
            SceneManager.LoadScene(3);
          }
          if(collision.gameObject.tag == "casaNivel03")
          {
             //nivel 4
            textoPantalla.scoreTexto.text  = "" + (int.Parse(textoPantalla.scoreTexto.text) + int.Parse(textoPantalla.tiempoTexto.text)) ;
            Debug.Log("Rick paso nivel 3!");
            textoPantalla.tiempo = 80.0f;
            SceneManager.LoadScene(4);
          }
          if(collision.gameObject.tag == "barco")
          {
             //nivel 4
              Instantiate (textoFinal);
              Instantiate (sonidoFelicidad);
              Destroy(this);
          }
           // Nivel 02 
          // Enemys
          if(collision.gameObject.tag == "enemy")
          {
          	Debug.Log("Rick murio por el enemy");
            textoPantalla.vidaTexto.text  = "" + (int.Parse(textoPantalla.vidaTexto.text) - 1) ;
            Init(SceneManager.GetActiveScene().name);
          }
          // Nivel 03
          //Enemys 
          //nativo
 
      }//aqui termina el void OnCollisionEnter
  
   public void OnCollisionStay2D(Collision2D collision)
   {
      if((collision.gameObject.tag == "pisoselva"|| collision.gameObject.tag =="plataforma" || collision.gameObject.tag == "paredIzquierda") && (Input.GetAxis("Jump")== 0))
      {
          aRick.SetBool("piso",true);
                                                
      }
      


   } //fin de oncollisionStay
     

} //aqui termina el public class
