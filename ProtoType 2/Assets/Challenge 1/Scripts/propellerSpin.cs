﻿using UnityEngine;

public class propellerSpin : MonoBehaviour
{
    private float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
