using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohSpawn : MonoBehaviour
{

    // ������ ���۵Ǹ� ���� �����ϰ� ������ ������ش�.

    public GameObject spawnPrefab;
    public GameObject spawnPrefab2;
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
        GameObject newPooh = Instantiate(spawnPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnSpeedPooh()
    {
        spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 5f);
        GameObject newPooh2 = Instantiate(spawnPrefab2, spawnPosition, Quaternion.identity);

        // ���ο� Pooh ������Ʈ�� ���� ��ũ��Ʈ�� �����ͼ� �ӵ��� ����
        PoohSpeed poohSpeed = newPooh2.GetComponent<PoohSpeed>();
        if (poohSpeed != null)
        {
            // ���ϴ� �ӵ��� ����
            poohSpeed.speed = 8f;
        }
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
        // �� ��° ���ο� ��&���� ������ ������ ����
        
    }
}
