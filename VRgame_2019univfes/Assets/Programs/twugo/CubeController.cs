﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float cubeSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(cubeSpeed * Input.GetAxis("Horizontal"), cubeSpeed * Input.GetAxis("Vertical"), 0);
    }
}
