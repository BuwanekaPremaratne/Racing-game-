using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class TrackCntrl : MonoBehaviour
{

     public float scrollSpeed = 1.0f;
    public Renderer roadRenderer;

    private float offset = 0.0f;

    void Update()
    {
        // Calculate the new offset based on time and scroll speed
        offset += scrollSpeed * Time.deltaTime;

        // Apply the offset to the material's main texture vertically
        roadRenderer.material.mainTextureOffset = new Vector2(0.0f, offset);
    }

}
