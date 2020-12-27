using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class overMessage : MonoBehaviour
{
    
    public TextMeshProUGUI textbox;
    
    // Start is called before the first frame update
    void Start()
    {
        string[] messages = new string[] {"U Ded","Game Over","Worse Luck Next Time","Epic Fail","Nice Try","f","You are Aliven't"};
        int index = Random.Range(0, messages.Length);
        textbox.text = messages[index];
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
