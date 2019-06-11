﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            Vector3 position = this.transform.position;
            position.y = position.y + (float)0.2;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y = position.y - (float)0.2;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + (float)0.2;
            this.transform.position = position;
            if (transform.localScale.x > 0)
            {
                transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1, 1, 1));
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - (float)0.2;
            this.transform.position = position;
            if (transform.localScale.x < 0)
            {
                transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1, 1, 1));
            }
        }
    }
}
