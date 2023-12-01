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
        //���ӸŴ����� �ʱ�ȭ�ϰ�
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pooh"))
        {
            Destroy(collision.gameObject);
            _poohController.count++;
            _gameManager.Score++;
            //���ӸŴ����� �������� ������ �����ش� ++;
            Debug.Log("��Ҵ�!");
        }
        else if (collision.gameObject.CompareTag("BottomPooh"))
        {
            Destroy(collision.gameObject);
            Debug.Log("�����ƴ�!");
        }
        
        /*//�÷��̾ �߰��ؾߴ� ��
        else if (collision.gameObject.CompareTag("//�˵�"))//����
        {
            // ���ӿ���
            //���� ���� UIâ �ҷ�����
            //�ð� ���߱�
        }*/
        // ���߿� �ٸ� �±װ� ���� �˿� ���� �浹�� �����ϰ������ ������ �Ȱ��� tag�� �����ؼ� �߰����ָ� �ȴ�.
    }

}
