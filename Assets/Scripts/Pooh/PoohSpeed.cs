using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoohSpeed : MonoBehaviour
{

    public float speed = 5f;


    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
