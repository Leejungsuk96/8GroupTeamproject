using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : PoopCharacterController
{
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

        // 여기다가 알약 먹었을 때 알약 스크립트에서 실행될 함수 가져오기.
        
    }
}
