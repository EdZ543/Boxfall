using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraY : MonoBehaviour
{
     public GameObject character;
     public GameObject lava;

     Vector3 pos;
     Vector3 pos2;
     Vector3 pos3;

    public float up;

    // Update is called once per frame
    void Update()
    {
        
        if(character != null){
        pos = transform.position;
        pos2 = character.transform.position;
        pos3 = lava.transform.position;


        pos.y = pos2.y;
        pos.x = pos2.x;
        
        
        gameObject.transform.position = pos;
        }
        
    }
}
