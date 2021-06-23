﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform playerTransform;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 temp = transform.position;
        temp.x = playerTransform.position.x;
        temp.x += offset;
        transform.position = temp;
    }
}
