using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : PlayerInvincibility
{
    private float invincibilityDuration = 5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Poop") || collision.gameObject.CompareTag("BottomPoop"))
        {
            GameManager.I.GameOver();
            //Time.timeScale = 0f;
            //gameManger.EndPanel.SetActive(true);
            // retry ��ư �������� Ÿ�� �ٽ� 1�� ����
            Debug.Log("��Ҵ�!");
        }
        else if (collision.gameObject.CompareTag("Pill"))
        {            
            bluePill(true);            
            GameManager.I.InvincibilityTimeDown();            
            Invoke("EndInvincibility", invincibilityDuration);
            collision.gameObject.SetActive(false);
        }
    }

    private void EndInvincibility()
    {
        bluePill(false);
    }
}
