using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohController : MonoBehaviour
{
    // 여기는 똥을 몇개나 피했는지 카운트 해주고 그 수 만큼 똥 생성을 많이 해준다.
    // 그러면 Collision에서 카운트 받아오고, Spawn률을 증가시켜주기.

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
            Debug.Log("생성수 증가!");
        }
    }
}
