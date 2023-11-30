using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohSpawn : MonoBehaviour
{

    // ������ ���۵Ǹ� ���� �����ϰ� ������ ������ش�.

    public GameObject spawnPrefab;
    Vector3 spawnPosition;


    float nextSpawnTime = 0f;
    public float spawnRate = 2f;// �� ���� �����Ͽ� �� ���� ������ ����.

    
    void Update()
    {

        if (Time.time >= nextSpawnTime)
        {
            SpawnPooh();
            nextSpawnTime = Time.time + 1f / spawnRate;

        }

    }

    //���⿡ Instantiate�� �� ���� �޼��� �����

    void SpawnPooh()
    {
        spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 5f);
        GameObject newPooh = Instantiate(spawnPrefab, spawnPosition, Quaternion.identity);
    }
}
