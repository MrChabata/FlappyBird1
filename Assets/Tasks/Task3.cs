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
            Debug.Log("����� ��������");
        }
        else
        {
            Debug.Log("�������� ������");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
