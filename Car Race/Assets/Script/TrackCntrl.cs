using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class TrackCntrl : MonoBehaviour
{

    public float scrollSpeed = 1.0f;
    public Renderer roadRenderer;

    private float offset = 0.0f;

    public bool isScrowlling=false;

    void Update()
    {
        if(isScrowlling)
        {
            StartScrolling();
        }


    }

    void StartScrolling()
    {
        offset += scrollSpeed * Time.deltaTime;
        roadRenderer.material.mainTextureOffset = new Vector2(0.0f, offset);

    }

}
