using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohController : MonoBehaviour
{
    // ����� ���� ��� ���ߴ��� ī��Ʈ ���ְ� �� �� ��ŭ �� ������ ���� ���ش�.
    // �׷��� Collision���� ī��Ʈ �޾ƿ���, Spawn���� ���������ֱ�.

    public int count = 0;
    PoohSpawn _poohSpawn;

    void Start()
    {
        _poohSpawn = FindObjectOfType<PoohSpawn>();
    }



    void Update()
    {

        if (count == 20)
        {
            _poohSpawn.spawnRate += 0.2f;
            count = 0;
            Debug.Log("������ ����!");
        }
    }
}
