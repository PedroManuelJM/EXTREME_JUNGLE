using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerNivel04 : MonoBehaviour
{
    public Rick rick;
	public GameObject sonidoDinosaurio;
    public Nativo nativo;
    public Dinosaurio dinosaurio;
    
    // Start is called before the first frame update
    void Start()
    {
        Rick r3 =Instantiate(rick) as Rick; 
        Scene scene = SceneManager.GetActiveScene();
        r3.Init(scene.name);
        Instantiate (sonidoDinosaurio);
        Nativo n1 = Instantiate(nativo) as Nativo;
        Nativo n2 = Instantiate(nativo) as Nativo;
        Dinosaurio d1 = Instantiate(dinosaurio) as Dinosaurio;
        //float initX , float initY, float distancia , bool direccion , bool direccion
        n1.Init(1.46f,-2.70f,8.23f,true,true); // hasta 9.69
        n2.Init(32.46f,-2.70f,7.00f,true,true); // hasta 39.46
        d1.Init(16.3f,-1.63f);
        //Enemys


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
