using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIController : MonoBehaviour
{
    public GameObject text;
    void Start()
    {
    }

    void Update()
    {
        if (text.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
        {
            text.SetActive(false);
        }
    }
}
