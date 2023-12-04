using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohSpawn : MonoBehaviour
{

    // ������ ���۵Ǹ� ���� �����ϰ� ������ ������ش�.

    public GameObject PrefabNormalPooh;
    public GameObject PrefabSpeedPooh;
    public GameObject PrefabBottomPooh;
    Vector3 spawnPosition;


    float nextSpawnTime = 0f;
    public float spawnRate = 2f;// �� ���� �����Ͽ� �� ���� ������ ����.

    
    void Update()
    {

        if (Time.time >= nextSpawnTime)
        {
            SpawnPooh();
            SpawnRandomPooh();
            nextSpawnTime = Time.time + 1f / spawnRate;

        }

    }

    //���⿡ Instantiate�� �� ���� �޼��� �����

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

    //���� �����ϰ� �����ϰ� ���ִ� �Լ�
    void SpawnRandomPooh()
    {
        // 0�� 1 ������ ������ �� ����
        float randomValue = Random.value;

        // �������� ���� �ٸ� �� ����
        if (randomValue < 0.3f)
        {
            // ù ��° ���ο� �� ���� ����
            SpawnSpeedPooh();
        }
        else if(randomValue < 7f)
        {
            // �� ��° �Ʒ� �� ����
            SpawnBottomPooh();
        }
        // �ٸ� ���ο� ��&���� ������ ������ ����
        
    }
}
