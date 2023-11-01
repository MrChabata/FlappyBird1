using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] iceBlocks;
    private bool isGameStarted;
    private float topY = 1;
    private float bottomY = -1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGameStarted)
        {
            isGameStarted = true;
            SpawnerPlatform();
        }
    }

    private void SpawnerPlatform()
    {
        int randomIndex = Random.Range(0, iceBlocks.Length);
        Vector3 newPos = transform.position;
        float randomOffset = Random.Range(bottomY, topY);
        newPos.y += randomOffset;
        Instantiate(iceBlocks[randomIndex], newPos, Quaternion.identity);
    }
}
