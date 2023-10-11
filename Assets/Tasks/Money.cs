using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public float money;
    public float price;
    public bool confirm;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(money >= price)
        {
            confirm = true;
            Debug.Log("TheTradeIsConfirmed");
        }

        else
        {
            confirm = false;
            Debug.Log("TheTradeIsDeclined");
        }
    }
}
