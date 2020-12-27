using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignorePlayer : MonoBehaviour
{
   
   public GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(player != null){
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        
    }
}
