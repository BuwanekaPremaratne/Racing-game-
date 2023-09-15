using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Button leftButton;
    public Button rightButton;

    void Start()
    {
        leftButton.onClick.AddListener(MoveLeft);
        rightButton.onClick.AddListener(MoveRight);
    }

    void MoveLeft()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void MoveRight()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
