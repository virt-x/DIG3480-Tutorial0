﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text gameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            gameText.text = "Hello, my name is Xavier Virt.";
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
