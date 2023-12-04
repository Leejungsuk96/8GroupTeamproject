using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : PoopCharacterController
{
    GameManager gameManger;
    public void Awake()
    {
        gameManger = FindObjectOfType<GameManager>();
        
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
        if (collision.gameObject.CompareTag("Pooh"))
        {
            gameManger.GameOver();
            //Time.timeScale = 0f;
            //gameManger.EndPanel.SetActive(true);
            // retry 버튼 눌렀을때 타임 다시 1로 설정
            Debug.Log("닿았다!");
        }
    }
}
