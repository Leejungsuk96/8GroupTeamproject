using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohCollision : MonoBehaviour
{
    //���⿡�� �浹ó���� �������ش�.
    PoohController _poohController;
    GameManager _gameManager;

    private void Awake()
    {

        _poohController = FindObjectOfType<PoohController>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pooh"))
        {
            Destroy(collision.gameObject);
            _poohController.count++;
            _gameManager.Score++;
            Debug.Log("��Ҵ�!");
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
