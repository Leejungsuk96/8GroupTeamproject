using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSpawn : MonoBehaviour
{

    // ������ ���۵Ǹ� ���� �����ϰ� ������ ������ش�.

    public GameObject PrefabNormalPoop;
    public GameObject PrefabSpeedPoop;
    public GameObject PrefabBottomPoop;
    Vector3 spawnPosition;


    float nextSpawnTime = 0f;
    public float spawnRate = 2f;// �� ���� �����Ͽ� �� ���� ������ ����.

    void Update()
    {

        if (Time.time >= nextSpawnTime)
        {
            
            nextSpawnTime = Time.time + 1f / spawnRate;
            SpawnPoop();
            SpawnSpeedPoop();
            SpawnBottomPoop();
        }

    }

    //���⿡ Instantiate�� �� ���� �޼��� �����

    void SpawnPoop()
    {
        GameObject poop = GameManager.I.pool.Get(0);
        spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 5f);
        poop.transform.position = spawnPosition;
    }

    void SpawnSpeedPoop()
    {
        // 0�� 1 ������ ������ �� ����
        float randomValue = Random.value;
        if (randomValue < 0.4f)
        {
            GameObject poop = GameManager.I.pool.Get(1);
            spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 5f);
            poop.transform.position = spawnPosition;
        }
    }

    void SpawnBottomPoop()
    {
        float randomValue = Random.value;
        if (randomValue < 0.3f)
        {
            GameObject poop = GameManager.I.pool.Get(2);
            spawnPosition = new Vector3(-10f, -4.45f, 5f);
            poop.transform.position = spawnPosition;
        }
    }


}