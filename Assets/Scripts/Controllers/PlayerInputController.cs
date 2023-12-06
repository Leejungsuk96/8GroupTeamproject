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
            // retry ��ư �������� Ÿ�� �ٽ� 1�� ����
            Debug.Log("��Ҵ�!");
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

    // �˾�
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
