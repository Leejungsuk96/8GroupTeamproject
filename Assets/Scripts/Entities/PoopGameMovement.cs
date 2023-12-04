using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopGameMovement : MonoBehaviour
{
    private PoopCharacterController _controller;
    private Rigidbody2D _rigidbody;
    private Vector2 _movementDirection = Vector2.zero;
    private Vector3 leftPos;
    private Vector3 rightPos;
    private Vector3 bottomPos;
    public GameObject leftwall;
    public GameObject rightWall;
    public GameObject bottomWall;
    public float moveSpeed;
    public float jumpPower;
    bool isJumpAvailable;

    private void Awake()
    {
        _controller = GetComponent<PoopCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        leftPos = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        rightPos = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0));
        bottomPos = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));

        leftwall.transform.position = new Vector3(leftPos.x -0.5f, -4.5f, 0);
        rightWall.transform.position = new Vector3(rightPos.x + 0.5f, -4.5f, 0);
        bottomWall.transform.position = new Vector3(0, bottomPos.y - 0.5f, 0);

        _controller.OnMoveEvent += Move;
        _controller.OnJumpEvent += Jump;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void Jump(bool temp)
    {
        if (!isJumpAvailable)
        {
            isJumpAvailable = true;
            _rigidbody.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
        }
        else
        {
            return;
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bottom"))
        {
            isJumpAvailable = false;
        }
        
    }

    public void ApplyMovement(Vector2 direction)
    {
        direction = direction * moveSpeed;

        if(direction.x > 0)
        {
            _rigidbody.velocity = new Vector2(20, _rigidbody.velocity.y);
        }
        else if(direction.x < 0)
        {
            _rigidbody.velocity = new Vector2(-20, _rigidbody.velocity.y);
        }
        else
        {
            _rigidbody.velocity =  new Vector2(0, _rigidbody.velocity.y);
        }
    }

}
