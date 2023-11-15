using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] iceBlocks;
    private bool isGameStarted;
    private float topY = 1;
    private float bottomY = -1;
    bool flag = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.isPause) return;
        if (!Global.isAlive)
        {
            StopCoroutine("Courutin");
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isGameStarted)
        {
            isGameStarted = true;
            SpawnerPlatform();
        }

        if (isGameStarted && !flag)
        {
            StartCoroutine("Courutin");
            flag = true;
        }
    }

    IEnumerator Courutin()
    {
        int randomTime = Random.Range(3, 5);
        yield return  new WaitForSeconds(randomTime);
        SpawnerPlatform();
        StartCoroutine("Courutin");
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
