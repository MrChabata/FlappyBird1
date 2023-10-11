using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    public float b = 3f;
    public float x;
    public float y;
    void Start()
    {
        float weight;
        weight = (b * x * y) / 1024;
        Debug.Log(weight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
