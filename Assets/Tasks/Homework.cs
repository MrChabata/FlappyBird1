using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    public float C;
    void Start()
    {
        float F = 9 / 5 * C + 32;
        Debug.Log(F);
        float K = 27315 / 100 + C;
        Debug.Log(K);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
