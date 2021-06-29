using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	//crear el objeto para luego instanciarlo a unity
	public Rick rick;
	public Plataforma plataforma;
	public Rinoceronte rinoceronte;
	public Leon leon;
	public Plataforma2 plataforma2;
	public Gorilon gorilon;
	public GameObject sonido_principal;
	    // Start is called before the first frame update
    void Start()
    {  //poniendo f al final lo pasamos a float
        Rick r2 =Instantiate(rick) as Rick; 
        Scene scene = SceneManager.GetActiveScene();
        r2.Init(scene.name);
       //sonido principal
        Instantiate (sonido_principal);
       //instaciar 2 plataformas
        Plataforma pf1 = Instantiate (plataforma) as Plataforma;
        Plataforma2 pf2 = Instantiate (plataforma2) as Plataforma2;
        pf1.Init(-5.95f,-0.17f);
        //plataforma2
        pf2.Init(11.42f,0.22f);

        Rinoceronte rt1 = Instantiate(rinoceronte) as Rinoceronte;
        rt1.Init(-4.49f,3.32f);
         

        Leon l1 = Instantiate(leon) as Leon;
        l1.Init(3.9f,-3.34f);

        Gorilon g1 =Instantiate(gorilon) as Gorilon;
        g1.Init(-4.36f,0.34f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
