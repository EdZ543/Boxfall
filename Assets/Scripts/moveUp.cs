using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
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

        pos.y += 0.01f;

        gameObject.transform.position = pos;
        
    }
}
