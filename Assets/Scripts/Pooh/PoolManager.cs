using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    // ������ ������ ����
    // Ǯ ��� �ϴ� ����Ʈ
    // ������ ���� = ����Ʈ ���� ������ߴ�
    public GameObject[] prefabs;

    List<GameObject>[] pools;

    private void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];

        for (int i = 0; i < pools.Length;  i++)
        {
            pools[i] = new List<GameObject>();
        }


    }

    public GameObject Get(int i)
    {
        GameObject select = null;
        // ������ Ǯ�� ��Ȱ��ȭ ������Ʈ�� ����
        foreach (GameObject item in pools[i]) 
        { 
            if (!item.activeSelf) 
            {
                select = item;
                select.SetActive(true);
                break;
            }
        }
        // Ǯ�� �� ������̶��?
        if (!select)
        {
            // ���Ӱ� ������Ʈ�� �����ϰ� select ������ �־��ֱ�
            select = Instantiate(prefabs[i], transform /*���⼭ transform�� �ǹ̴� �� ��ũ��Ʈ�� �� ������Ʈ �ȿ� �ڽ� ������Ʈ�� ������ �Ѵٴ� �ǹ̴�.*/);
            pools[i].Add(select);
        }

        return select;
    }
}
