using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] iceBlocks;
    private bool isGameStarted;
    public float topY = 1;
    public float bottomY = -1;
    bool flag = false;
    public GameObject fish;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.isPause)
        {
            StopCoroutine("Courutin");
            return;
        }
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
        GameObject newBlock = Instantiate(iceBlocks[randomIndex], newPos, Quaternion.identity);
        if (Random.Range(0, 2) == 1)
        {
            Instantiate(fish, newBlock.transform.position, Quaternion.identity);
        }
        if(Global.isAlive == true && Global.isPause) Destroy(newBlock, 5);
    }
}
