using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : PoopCharacterController
{
    Pill pill;

    private float invincibilityDuration = 5f;
    private void Awake()
    {
        pill = FindObjectOfType<Pill>();//pill �ʱ�ȭ
    }

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
            pill.bluePill(true);
            Invoke("EndInvincibility", invincibilityDuration);
        }
    }

    private void EndInvincibility()
    {
        pill.bluePill(false);
    }
}
