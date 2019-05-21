﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_draw : MonoBehaviour {
    RenderTexture canvas;
    int canvas_size = 512;

    //brush
    Texture2D brush_positionMap;

    [SerializeField]
    Texture2D brush_stencil;

    [SerializeField]
    int brush_size = 50;

    [SerializeField]
    GameObject object_focused;

    [SerializeField]
    Color drawing_color;

    [SerializeField]
    Texture2D texture;
    //compute shader
    ComputeShader cs_draw;
    private int csKernel;

    public Camera cam;

    // Use this for initialization
    void Start () {
        loadTexture(texture);

        //setup compute shader
        cs_draw = (ComputeShader)Resources.Load("Shader/cs_drawing");
        csKernel = cs_draw.FindKernel("drawing");

        brush_positionMap = new Texture2D(brush_size * sc_UVCamera.scale_factor, brush_size * sc_UVCamera.scale_factor, TextureFormat.RGBAFloat, false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) {
            //Camera cam = FindObjectOfType<Camera>();
            cam.targetTexture = sc_UVCamera.uv_image;
            cam.Render();

            RenderTexture.active = sc_UVCamera.uv_image;
            Rect brush = new Rect(new Vector2((Input.mousePosition.x - (brush_size / 2)) * sc_UVCamera.scale_factor, (1280 - Input.mousePosition.y - (brush_size / 2)) * sc_UVCamera.scale_factor), new Vector2(brush_size * sc_UVCamera.scale_factor, brush_size * sc_UVCamera.scale_factor));
            brush_positionMap.ReadPixels(brush, 0, 0);
            brush_positionMap.Apply();

            cs_draw.SetTexture(csKernel, "Texture", canvas);
            cs_draw.SetTexture(csKernel, "UV", brush_positionMap);
            cs_draw.SetTexture(csKernel, "Stencil", brush_stencil);

            cs_draw.SetFloat("red", drawing_color.r);
            cs_draw.SetFloat("green", drawing_color.g);
            cs_draw.SetFloat("blue", drawing_color.b);

            cs_draw.Dispatch(csKernel, brush_positionMap.width / 8, brush_positionMap.height / 8, 1);

            object_focused.GetComponent<Renderer>().material.mainTexture = canvas;
        }
    }

    private void loadTexture(Texture2D src) {
        if(canvas != null) {
            DestroyImmediate(canvas);
        }
        //setup drawing texture
        canvas = new RenderTexture(src.width, src.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Default);
        canvas.enableRandomWrite = true;
        canvas.filterMode = FilterMode.Point;
        canvas.anisoLevel = 0;
        canvas.Create();
        Graphics.Blit(src, canvas);
    }

    public static void test() {
        Debug.Log("test");
    }
}

