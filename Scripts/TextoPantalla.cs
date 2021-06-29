using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextoPantalla : MonoBehaviour
{
    private Rick rick;
    private CameraRick camera;
    public TextMeshPro tituloVida;
    public TextMeshPro vidaTexto;
    public TextMeshPro tiempoTexto;
    public TextMeshPro tituloScore;
    public TextMeshPro scoreTexto;
    private float posX;
    private float posY;
    private int vida;
    private int score;
    public float tiempo = 80.0f;
    private string tiempoPrefsName = "Tiempo";
    private string vidaPrefsName = "Vida";
    private string scorePrefsName = "Score";

    private void Awake() {
        LoadData();
    }

    private void OnDestroy() {
        SaveData();
    }

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        camera = FindObjectOfType<CameraRick>();
        rick = FindObjectOfType<Rick>();
        Init();
        TimeJuego();
    }

    public void Init(){
        
        posY = camera.transform.position.y + 0.42f;
        posX = camera.transform.position.x + 4.78f;
        tituloVida.transform.position = new Vector3(posX,posY,-1.0f);
        posX = camera.transform.position.x + 6.50f;
        vidaTexto.transform.position = new Vector3(posX,posY,-1.0f);
        posX = camera.transform.position.x + 9.53f;
        tiempoTexto.transform.position = new Vector3(posX,posY,-1.0f);
        posX = camera.transform.position.x + 12.54f;
        tituloScore.transform.position = new Vector3(posX,posY,-1.0f);
        posX = camera.transform.position.x + 14.4f;
        scoreTexto.transform.position = new Vector3(posX,posY,-1.0f);

    }

    public void TimeJuego(){
        tiempo -= Time.deltaTime;
        tiempoTexto.text = "" + tiempo.ToString("f0");
        if(tiempoTexto.text == "0"){
            tiempo = 80.0f;
            vidaTexto.text  = "" + (int.Parse(vidaTexto.text) - 1) ;
            rick.Init(SceneManager.GetActiveScene().name);
        }
    }


    private void SaveData(){
        PlayerPrefs.SetInt(vidaPrefsName,vida);
        PlayerPrefs.SetInt(scorePrefsName,score);
        PlayerPrefs.SetFloat(tiempoPrefsName,40.0f);
    }

    private void LoadData(){
        vida = PlayerPrefs.GetInt(vidaPrefsName,1);
        score = PlayerPrefs.GetInt(scorePrefsName,0);
        tiempo = PlayerPrefs.GetFloat(tiempoPrefsName,40.0f);
    }


}
