using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart()
    {
    	SceneManager.LoadScene("Nivel01"); // nombre de la escena
        
    }

    // Update is called once per frame
    public void BotonExit()
    {
    	Application.Quit();
        
    }
}
