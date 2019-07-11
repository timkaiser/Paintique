﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_texture_loader : MonoBehaviour
{
    GameObject obj;
    public Texture2D texture;
    
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("paintable");

        obj.GetComponent<Renderer>().material.mainTexture = texture;
    }

    public void setTexture(Texture2D tex) {
        texture = tex;

        obj.GetComponent<Renderer>().material.mainTexture = tex;
    }
}