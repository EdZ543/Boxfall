using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeUI : MonoBehaviour
{
    
    public GameObject objection;

    // Update is called once per frame
    void Update()
    {
        scorecounter scription = objection.GetComponent<scorecounter>();
        
        if(scription.isded == 1){
            Destroy(gameObject);
        }
    }
}
