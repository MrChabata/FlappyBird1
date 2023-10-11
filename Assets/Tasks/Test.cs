using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float a;
    public float b;
    void Start()
    {
        float sum = a * a + b * b;
        Debug.Log(sum);
        float ras = a * a - b * b;
        Debug.Log(ras);
        float del = (a * a) / (b * b);
        Debug.Log(del);
        float pro = (a * a) * (b * b);
        Debug.Log(pro);
    }

    void Update()
    {
        
    }
}
