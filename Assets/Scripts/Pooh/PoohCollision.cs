using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohCollision : MonoBehaviour
{
    //���⿡�� �浹ó���� �������ش�.
    PoohSpawn _poohSpawn;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pooh"))
        {
            Destroy(collision.gameObject);
            _poohSpawn.spawnRate ++;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            // ���ӿ���
            //���� ���� UIâ �ҷ�����
            //�ð� ���߱�
        }
        // ���߿� �ٸ� �±װ� ���� �˿� ���� �浹�� �����ϰ������ ������ �Ȱ��� tag�� �����ؼ� �߰����ָ� �ȴ�.
    }

}
