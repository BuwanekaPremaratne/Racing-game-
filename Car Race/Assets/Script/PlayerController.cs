using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 position;
    public Image car;

    private bool moveLeft = false;
    private bool moveRight = false;

    void Start()
    {
        position = car.transform.position;
    }

    void Update()
    {
        if (moveLeft)
        {
            // Move the car to the left
            position.x -= speed * Time.deltaTime;
        }
        else if (moveRight)
        {
            // Move the car to the right
            position.x += speed * Time.deltaTime;
        }

        // Update the car's position continuously
        car.transform.position = position;
    }

    public void OnLeftButtonDown()
    {
        moveLeft = true;
    }

    public void OnLeftButtonUp()
    {
        moveLeft = false;
    }

    public void OnRightButtonDown()
    {
        moveRight = true;
    }

    public void OnRightButtonUp()
    {
        moveRight = false;
    }
}