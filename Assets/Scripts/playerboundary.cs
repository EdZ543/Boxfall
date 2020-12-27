using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerboundary : MonoBehaviour
{

    Vector3 pos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        
        if(pos.x < -27.8f){
           pos.x = -27.8f;
        }

        if(pos.x > 38){
           pos.x = 38;
        }
        gameObject.transform.position = pos;
    }
}
