﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(0, 11);
    }
}
