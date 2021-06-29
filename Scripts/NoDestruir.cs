using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestruir : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake(){
        var noDestruirEntreEscenas = FindObjectsOfType<NoDestruir>();
        if(noDestruirEntreEscenas.Length > 1){
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
