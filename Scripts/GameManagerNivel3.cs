using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerNivel3 : MonoBehaviour
{
	public Rick rick;
	public Nativo nativo;
	public Spider spider;
	public Cocodrile cocodrilo;
	public GameObject sonido_lluvia;
	public Plataformanivel1 plataformanivel1;


    // Start is called before the first frame update
    void Start()
    {
        Rick r3 =Instantiate(rick) as Rick; 
        Scene scene = SceneManager.GetActiveScene();
        r3.Init(scene.name);
        Instantiate (sonido_lluvia);
        //Enemys

        Nativo n1 =Instantiate(nativo)as Nativo;
        n1.Init(-6.083f,2.59f);
        
        Spider s1= Instantiate(spider)as Spider;
        s1.Init(-6.54f,-0.47f);

       Cocodrile c1=Instantiate(cocodrilo)as Cocodrile;
       c1.Init(21.6f,-4.07f);

       //plataformas
       Plataformanivel1 pf1 =Instantiate(plataformanivel1) as Plataformanivel1;
       Plataformanivel1 pf2 =Instantiate(plataformanivel1) as Plataformanivel1;
       Plataformanivel1 pf3 =Instantiate(plataformanivel1) as Plataformanivel1;
       Plataformanivel1 pf4 =Instantiate(plataformanivel1) as Plataformanivel1;
       //float initX , float initY, float distancia , bool direccion , int move
       pf1.Init(-6.25f,-4.10f,5.15f,true,true,2); // hasta -1.10
       pf2.Init(5.35f,-4.10f,-5.15f,true,false,-2); // desds 5.35 hasta 0.20
       pf3.Init(6.65f,-4.10f,5.15f,true,true,2); // hasta 11.80
       pf4.Init(18.40f,-4.10f,-5.15f,true,false,-2); // hasta 11.80

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
