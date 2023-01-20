using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public string gameInstructions = "Move the player by using the W,A,S and D keys";
    byte sampleByte;//0-255
    int sampleInt;//-2,000,000 to 2,000,000
    float sampleFloat; //1.14, 98.888
    //camelCase

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameInstructions);
    }   
    
}
