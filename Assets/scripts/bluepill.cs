

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ItemType//������ ���
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

    IEnumerator ActivateInvincibility(float duration)//����Ȱ������
    {
        isInvincible = true;//���� ������ Ȱ��ȭ�Ǹ� 
        yield return new WaitForSeconds(duration);//�����ð����� �۾��ϴ� �ൿ(�¾����� �״��ൿ)�� �ƹ��۾��� ���������ʰ� ����ϴ� ��Ȱ
        isInvincible = false;//������ Ȱ��ȭ �����ʾ������
    }

    IEnumerator SlowDownDroppingSpeed(float duration)
    {
        // ���� ���� �ӵ�
        float originalSpeed = 0; // ���� ���� �ӵ��� �������� �ڵ�

        // ���� �ӵ��� ���ߴ� �ڵ�
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector3(0f, -1f, 0f); // ���ϴ� �ӵ��� �����ϱ�
        }

        yield return new WaitForSeconds(duration);

        // ������ �ӵ��� ���ư��� �ڵ带 �ۼ��մϴ�.
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
        // ������ ������ ������ �� ȣ��Ǵ� �޼����Դϴ�.
        SpawnItem();
    }

    void SpawnItem()
    {
        // �����ϰ� �������� �����մϴ�.
        int randomItemType = Random.Range(0, 2); // 0 �Ǵ� 1 �߿��� �����ϰ� �����մϴ�.

        // ���õ� �������� ������ ���� �ش� �������� �����մϴ�.
        GameObject newItem;
        if (randomItemType == 0)
        {
            newItem = Instantiate(bluePillPrefab, GetRandomSpawnPosition(), Quaternion.identity);
        }
        else
        {
            newItem = Instantiate(redPillPrefab, GetRandomSpawnPosition(), Quaternion.identity);
        }

        // ������ �������� �÷��̾�� ��ȣ�ۿ��ϵ��� �����Ѵ�.
        newItem.GetComponent<ItemPickup>().SetPlayerReference(player);
    }

    Vector3 GetRandomSpawnPosition()
    {
        // ������ ��ġ�� ��ȯ
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


