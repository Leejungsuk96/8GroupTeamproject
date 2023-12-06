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
            // retry 버튼 눌렀을때 타임 다시 1로 설정
            Debug.Log("닿았다!");
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
