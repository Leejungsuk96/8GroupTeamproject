using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class CameraMove : MonoBehaviour
{
    private Vector2 CameraPosition;
    float Y;
    float LastCameraY = 0f;
    private bool state;
    public GameObject Target;
    public GameObject button;
    private GameObject Camera;
    

   
    private void Start()
    {
        state = false;
    }
    private void Awake()
    {
        CameraPosition = new Vector2(0, Y);
        Y = -7.7f;
        Camera=GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void Update()
    {

        if (transform.position.y < 0)
        {
            
            transform.Translate(Vector3.up * 1f * Time.deltaTime);
            if (Input.anyKeyDown)
            {
                Debug.Log("ÀÔ·ÂµÊ");
                
                transform.position = new Vector3(0, 0, -10);
            }
            
            
        }
        else  
        {
            
            Target.SetActive(true);
            button.SetActive(true);
            state = true;
        }
        
        
        

    }

    
        
        
    
}
