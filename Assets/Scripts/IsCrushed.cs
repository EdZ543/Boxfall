using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCrushed : MonoBehaviour
{
    GameObject player;
    
    public GameObject character;
    
    void OnTriggerEnter2D(Collider2D other){

       
            
            Destroy(character);
        
        

    }
}
