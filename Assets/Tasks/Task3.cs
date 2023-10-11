using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public float temperature;
    void Start()
    {
        if(temperature > 25 && temperature < 45)
        {
            Debug.Log("Можно купаться");
        }
        else
        {
            Debug.Log("Купаться нельзя");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
