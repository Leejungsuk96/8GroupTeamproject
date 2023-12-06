using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : PlayerInvincibility
{
    private float invincibilityDuration = 5f;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Poop") || collision.gameObject.CompareTag("BottomPoop"))
        {
            GameManager.I.GameOver();
            //Time.timeScale = 0f;
            //gameManger.EndPanel.SetActive(true);
            // retry 버튼 눌렀을때 타임 다시 1로 설정
        }
        else if (collision.gameObject.CompareTag("Pill"))
        {            

            if(gameObject.layer == LayerMask.NameToLayer("Deactive"))
            {
                bluePill(true);
                spriteRenderer.color = new Color(30f, 0f, 255f);
                AudioManager.I.GetPillSound();
                GameManager.I.InvincibilityTimeDown();
                Invoke("EndInvincibility", invincibilityDuration);
                collision.gameObject.SetActive(false);
            }
            else if(gameObject.layer == LayerMask.NameToLayer("Active"))
            {
                CancelInvoke("EndInvincibility");
                AudioManager.I.GetPillSound();
                GameManager.I.InvincibilityTime = 5f; //만약 무적시간 바꾸면 이것도 같이 바꿔줘야댐.
                GameManager.I.InvincibilityTimeDown();
                Invoke("EndInvincibility", invincibilityDuration);
                collision.gameObject.SetActive(false);
            }
            
        }
    }

    private void EndInvincibility()
    {
        bluePill(false);
        spriteRenderer.color = Color.white;
    }
}
