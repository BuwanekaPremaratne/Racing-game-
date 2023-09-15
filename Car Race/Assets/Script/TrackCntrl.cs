using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class TrackCntrl : MonoBehaviour
{
    public float speed = 1.0f;
    private Material material;

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        float offsetX = Time.time * speed;

        Vector2 offset = new Vector2(offsetX, 0f);

        material.mainTextureOffset = offset;
    }
}
