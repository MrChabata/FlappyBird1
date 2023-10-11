using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public int a;
    public float b;
    public int c;
    public float s;
    void Start()
    {
        float price;
        price = (s - a * b) / c;
        Debug.Log(price);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
