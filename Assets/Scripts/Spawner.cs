using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] iceBlocks;
    void Start()
    {
        int randomIndex = Random.Range(0, iceBlocks.Length);
        Instantiate(iceBlocks[randomIndex], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
