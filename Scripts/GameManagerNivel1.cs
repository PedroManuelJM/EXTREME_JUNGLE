using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerNivel1 : MonoBehaviour
{
	public Rick rick;
	public Plataformanivel1 plataformanivel1;
    public GameObject sonido;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate (sonido);
        Rick r1 =Instantiate(rick) as Rick; 
        Scene scene = SceneManager.GetActiveScene();
        r1.Init(scene.name);

        //plataforma
        Plataformanivel1 pf1 =Instantiate(plataformanivel1) as Plataformanivel1;
        Plataformanivel1 pf2 =Instantiate(plataformanivel1) as Plataformanivel1;
        pf1.Init(-2.31f,-3.31f,1.64f,false,true,2);
        pf2.Init(4.21f,-1.88f,2.34f,false,true,2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
