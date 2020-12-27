using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{

    public GameObject objection;
    public GameObject crate;

    void OnTriggerEnter2D(Collider2D other){
       
        if(other.tag == "Player"){
         
          bombcounter scription = objection.GetComponent<bombcounter>();
          scription.bombs += 1;
          Destroy(gameObject);
          Destroy(crate);
         
        }
        
        
    } 
}
