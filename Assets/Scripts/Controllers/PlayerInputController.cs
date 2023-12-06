using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : PoopCharacterController
{

    private float invincibilityDuration = 5f;
    private bool isInvincible = false;

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnJump(InputValue value)
    {
        CallJumpEvent(value.isPressed);
    }

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
            Invoke("EndInvincibility", invincibilityDuration);
            collision.gameObject.SetActive(false);
        }
    }

    private void EndInvincibility()
    {
        bluePill(false);
    }

    // 알약
    public void bluePill(bool invincible)
    {
        if (invincible)
        {
            gameObject.layer = LayerMask.NameToLayer("Active");
        }
        else
        {
            gameObject.layer = LayerMask.NameToLayer("Deactive");
        }
    }
}
