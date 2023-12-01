using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleAnimation : MonoBehaviour
{
    
    float rightMax = 10.0f;
    float leftMax = -10.0f;
    float currentPosition;
    float direction = 5f;
    
    [SerializeField] private SpriteRenderer chararcterRenderer;

    void Start()
    {
        currentPosition = transform.position.x;
        

    }
    void Update()
    {
        currentPosition += Time.deltaTime * direction;
        if (currentPosition > rightMax)
        {
            direction *= -1;
            currentPosition = rightMax;
            chararcterRenderer.flipX = false;

        }
        else if (currentPosition < leftMax) 
        {
            direction *= -1;
            currentPosition = leftMax;
            
            chararcterRenderer.flipX = true;
            
        }
        transform.position=new Vector3 (currentPosition, 3, 0);
    }



}
