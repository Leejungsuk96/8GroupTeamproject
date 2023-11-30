using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohSpawn : MonoBehaviour
{

    // 게임이 시작되면 똥이 랜덤하게 나오게 만들어준다.

    public GameObject spawnPrefab;
    Vector3 spawnPosition;


    float nextSpawnTime = 0f;
    public float spawnRate = 2f;// 이 값을 조절하여 똥 생성 간격을 조정.

    
    void Update()
    {

        if (Time.time >= nextSpawnTime)
        {
            SpawnPooh();
            nextSpawnTime = Time.time + 1f / spawnRate;

        }

    }

    //여기에 Instantiate로 똥 생성 메서드 만들기

    void SpawnPooh()
    {
        spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 5f);
        GameObject newPooh = Instantiate(spawnPrefab, spawnPosition, Quaternion.identity);
    }
}
