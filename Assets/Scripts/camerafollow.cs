using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
   
     public GameObject character;

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
         pos2 = character.transform.position;

        pos.x = pos2.x;
        
        gameObject.transform.position = pos;
        
    }
}
