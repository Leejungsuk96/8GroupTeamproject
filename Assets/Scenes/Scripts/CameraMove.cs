using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector2 Camera;
    float Y;


    private void Awake()
    {
        Camera = new Vector2(0, Y);
        Y = -10f;
    }

    // Update is called once per frame
    private void Update()
    {

        if (Y < 0)
        {
            Y += Time.deltaTime;
            transform.Translate(Vector2.up * 1f * Time.deltaTime);
        }
        else
        {

        }


    }
}
