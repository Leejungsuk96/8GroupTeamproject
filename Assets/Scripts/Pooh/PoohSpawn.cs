using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohSpawn : MonoBehaviour
{

    // 게임이 시작되면 똥이 랜덤하게 나오게 만들어준다.

    public GameObject PrefabNormalPooh;
    public GameObject PrefabSpeedPooh;
    public GameObject PrefabBottomPooh;
    Vector3 spawnPosition;


    float nextSpawnTime = 0f;
    public float spawnRate = 2f;// 이 값을 조절하여 똥 생성 간격을 조정.

    
    void Update()
    {

        if (Time.time >= nextSpawnTime)
        {
            SpawnPooh();
            SpawnRandomPooh();
            nextSpawnTime = Time.time + 1f / spawnRate;

        }

    }

    //여기에 Instantiate로 똥 생성 메서드 만들기

    void SpawnPooh()
    {
        spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 5f);
        GameObject newPooh = Instantiate(PrefabNormalPooh, spawnPosition, Quaternion.identity);
    }

    void SpawnSpeedPooh()
    {
        spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 5f);
        GameObject newSpeedPooh = Instantiate(PrefabSpeedPooh, spawnPosition, Quaternion.identity);
    }

    void SpawnBottomPooh()
    {
        spawnPosition = new Vector3(-10f, -4.5f, 5f);
        GameObject newBottomPooh = Instantiate(PrefabBottomPooh, spawnPosition, Quaternion.identity);
    }

    //똥을 랜덤하게 생성하게 해주는 함수
    void SpawnRandomPooh()
    {
        // 0과 1 사이의 랜덤한 값 생성
        float randomValue = Random.value;

        // 랜덤값에 따라 다른 똥 생성
        if (randomValue < 0.3f)
        {
            // 첫 번째 새로운 똥 종류 생성
            SpawnSpeedPooh();
        }
        else if(randomValue < 7f)
        {
            // 두 번째 아래 똥 생성
            SpawnBottomPooh();
        }
        // 다른 새로운 똥&버프 아이템 종류를 생성
        
    }
}
