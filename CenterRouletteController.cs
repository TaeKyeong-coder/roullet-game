using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterRouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            this.rotSpeed = 10;
        }

        if (Input.GetMouseButtonDown(1)){
            if(this.rotSpeed != 0)
                this.rotSpeed -= 1;
        }

        transform.Rotate(0, 0, this.rotSpeed);
    }
}
