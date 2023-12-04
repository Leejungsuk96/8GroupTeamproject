using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMap : MonoBehaviour
{
    private Vector3 leftPos;
    private Vector3 rightPos;
    private Vector3 bottomPos;
    public GameObject leftwall;
    public GameObject rightWall;
    public GameObject bottomWall;

    private void Start()
    {
        leftPos = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        rightPos = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0));
        bottomPos = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));

        leftwall.transform.position = new Vector3(leftPos.x - 0.5f, -4.5f, 0);
        rightWall.transform.position = new Vector3(rightPos.x + 0.5f, -4.5f, 0);
        bottomWall.transform.position = new Vector3(0, bottomPos.y + 0.4f, 0);
    }
}
