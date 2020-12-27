using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxspawner3 : MonoBehaviour
{
   
    public GameObject box;
    float randX;
    Vector2 spawnLocation;
    public float spawnRate = 0f;
    float nextSpawn = 55f;

    public GameObject character;
    public GameObject lava;

     Vector3 pos;
     Vector3 pos2;
     Vector3 pos3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnRate++;
        
        pos = transform.position;
        
        if(character != null){
        pos2 = character.transform.position;
        }
        
        pos3 = lava.transform.position;
        
        if(spawnRate >= nextSpawn && pos2.y < pos3.y + 113 && pos2.y > 123 && pauseMenu.isPaused == false && character != null){

            spawnRate = 0;
            randX = Random.Range(0f,65f);
            spawnLocation = new Vector2(transform.position.x + randX, transform.position.y);
            Instantiate(box, spawnLocation, Quaternion.identity);

        }
        
        if(character != null){
            pos.y = pos2.y + 20;
        }
        
        gameObject.transform.position = pos;
    }

}
