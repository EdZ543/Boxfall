using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn3 : MonoBehaviour
{
    
    public GameObject box;
    public GameObject box2;
    Vector3 pos;


    
        void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "lava"){
         
        

            Destroy(box);
            Destroy(gameObject);
            Instantiate(box2, pos, Quaternion.identity);

        
        
        }
    } 
    
    // Update is called once per frame
    void Update()
    {
       pos = transform.position;
       gameObject.transform.position = pos;
        
    }
}
    

