using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public int n;
    void Start()
    {
    }
    void Update()
    {
        if(n == 1)
        {
            Debug.Log("Monday");
        }

        else if (n == 2)
        {
            Debug.Log("Tuesday");
        }

        else if (n == 3)
        {
            Debug.Log("Wednesday");
        }

        else if (n == 4)
        {
            Debug.Log("Thursday");
        }

        else if (n == 5)
        {
            Debug.Log("Friday");
        }

        else if (n == 6)
        {
            Debug.Log("Saturday");
        }

        else if (n == 7)
        {
            Debug.Log("Sunday");
        }

    }
}
