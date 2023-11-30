using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohCollision : MonoBehaviour
{
    //여기에는 충돌처리를 구현해준다.

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pooh"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            // 게임오버
        }
        // 나중에 다른 태그가 붙은 똥에 대한 충돌을 구현하고싶으면 위에랑 똑같이 tag만 수정해서 추가해주면 된다.
    }

}
