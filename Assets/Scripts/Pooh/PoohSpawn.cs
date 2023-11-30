using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohSpawn : MonoBehaviour
{

    // 게임이 시작되면 똥이 랜덤하게 나오게 만들어준다.

    public GameObject spawnPrefab;
    public GameObject spawnPrefab2;
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
        GameObject newPooh = Instantiate(spawnPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnSpeedPooh()
    {
        spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 5f);
        GameObject newPooh2 = Instantiate(spawnPrefab2, spawnPosition, Quaternion.identity);

        // 새로운 Pooh 오브젝트에 대한 스크립트를 가져와서 속도를 설정
        PoohSpeed poohSpeed = newPooh2.GetComponent<PoohSpeed>();
        if (poohSpeed != null)
        {
            // 원하는 속도를 설정
            poohSpeed.speed = 8f;
        }
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
        // 두 번째 새로운 똥&버프 아이템 종류를 생성
        
    }
}
