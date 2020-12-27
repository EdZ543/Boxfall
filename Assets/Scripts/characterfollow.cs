using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterfollow : MonoBehaviour
{
   
     public GameObject character;

     Vector3 pos;
     Vector3 pos2;
    
    void Start(){

    }
    // Update is called once per frame
    void Update()
    {
        
        pos = transform.position;
        pos2 = character.transform.position;
        
        pos.y = pos2.y;
        gameObject.transform.position = pos;
        
    }
}
