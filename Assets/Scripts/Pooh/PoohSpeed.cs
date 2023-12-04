using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohSpeed : MonoBehaviour
{

    public float speed = 5f;


    void Update()
    {
        if (CompareTag("Pooh"))
        {
            Move();
        }
        else if (CompareTag("BottomPooh"))
        {
            MoveRight();
        }
    }

    void Move()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void MoveRight()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
