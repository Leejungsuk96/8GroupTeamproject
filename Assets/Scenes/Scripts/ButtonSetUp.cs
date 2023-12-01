using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSetUp : MonoBehaviour
{
    private bool state;
    public GameObject Target;

    void Start()
    {
        state = false;
    }
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            
            if (state == false) 
            { 
                Target.SetActive(true);
                state = true;
            }
        }
    }
}
