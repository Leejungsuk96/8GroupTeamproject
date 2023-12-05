

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ItemType//아이템 목록
{
    BluePill
    //RedPill
}

public ItemType Type;
public float Duration;

public class NewBehaviourScript : MonoBehaviour
{
    private bool isInvincible = false;
    private float originalSpeed;

    public void UseItem(ItemType item)
    {
        switch (item.Type)
        {
            case Item.ItemType.BluePill:
                StartCoroutine(ActivateInvicibility(item.duration));
                break;
            case Item.ItemType.RedPill:
                StartCoroutine(SlowDownDroppingSpeed(item.duration));
                break;
            default:
                break;
        }
    }

    IEnumerator ActivateInvincibility(float duration)//무적활성관련
    {
        isInvincible = true;//만약 무적이 활정화되면 
        yield return new WaitForSeconds(duration);//일정시간동안 작업하는 행동(맞았을때 죽는행동)을 아무작업도 수행하지않고 대기하는 역활
        isInvincible = false;//무적이 활성화 되지않았을경우
    }

    IEnumerator SlowDownDroppingSpeed(float duration)
    {
        // 현재 똥의 속도
        float originalSpeed = 0; // 똥의 현재 속도를 가져오는 코드

        // 똥의 속도를 늦추는 코드
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector3(0f, -1f, 0f); // 원하는 속도로 조절하기
        }

        yield return new WaitForSeconds(duration);

        // 원래의 속도로 돌아가는 코드를 작성합니다.
        if (rb != null)
        {
            rb.velocity = new Vector3(0f, -originalSpeed, 0f);
        }
    }
}

public class ItemSpawner : MonoBehaviour
{
    public GameObject bluePillPrefab;
    public GameObject redPillPrefab;

    void Start()
    {
        // 아이템 생성을 시작할 때 호출되는 메서드입니다.
        SpawnItem();
    }

    void SpawnItem()
    {
        // 랜덤하게 아이템을 생성합니다.
        int randomItemType = Random.Range(0, 2); // 0 또는 1 중에서 랜덤하게 선택합니다.

        // 선택된 아이템의 종류에 따라 해당 아이템을 생성합니다.
        GameObject newItem;
        if (randomItemType == 0)
        {
            newItem = Instantiate(bluePillPrefab, GetRandomSpawnPosition(), Quaternion.identity);
        }
        else
        {
            newItem = Instantiate(redPillPrefab, GetRandomSpawnPosition(), Quaternion.identity);
        }

        // 생성된 아이템을 플레이어와 상호작용하도록 설정한다.
        newItem.GetComponent<ItemPickup>().SetPlayerReference(player);
    }

    Vector3 GetRandomSpawnPosition()
    {
        // 랜덤한 위치를 변환
        float x = Random.Range(-5f, 5f);
        float y = Random.Range(1f, 5f);
        float z = 0f;

        return new Vector3(x, y, z);
    }
    // Update is called once per frame
    void Update()
    {

    }

}


