using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow2 : MonoBehaviour
{

    
    public GameObject player;
    
    Vector3 pos;
    Vector3 pos2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos2 = player.transform.position;
        
        pos.x = pos2.x;
        pos.y = pos2.y;

        gameObject.transform.position = pos;

    
        
    }
}
