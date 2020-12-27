using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    public GameObject objection;
    public GameObject boom;
    Vector3 pos;
    public GameObject Object;
    
    void OnMouseDown()
    {
        bombcounter scription = objection.GetComponent<bombcounter>();
        scorecounter script = Object.GetComponent<scorecounter>();
        
        if(scription.bombs  > 0 && script.isded < 1 && pauseMenu.isPaused == false){
        
        scription.bombs -= 1;
        Destroy(gameObject);
        GameObject clone = Instantiate(boom, transform.position, Quaternion.identity);
        Destroy(clone, 0.5f);
        
        }
    }
 
}
