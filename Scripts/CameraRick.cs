using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRick : MonoBehaviour
{
    private Rick rick;

    void FixedUpdate()
    {
        rick = FindObjectOfType<Rick>();
        float posX = rick.transform.position.x;
        float posY = rick.transform.position.y;
        transform.position = new Vector3(posX,posY,transform.position.z);
        
    }
    
   
}
