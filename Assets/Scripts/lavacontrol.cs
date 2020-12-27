using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavacontrol : MonoBehaviour
{
    Vector3 why;
    public float up;
    public GameObject player;
    public GameObject objection;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
       
        if(other.tag == "Player"){
         
        
        Destroy(player);
        scorecounter scription = objection.GetComponent<scorecounter>();
        scription.isded = 1; 
        
        
        }
    } 

    // Update is called once per frame
    void Update()
    {
        why = transform.position;
        if(pauseMenu.isPaused == false){
        why.y = why.y + up;
        }
        gameObject.transform.position = why;
    }
}
