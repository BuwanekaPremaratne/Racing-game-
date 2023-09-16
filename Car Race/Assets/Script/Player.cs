using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    PlayerController playerCtrl;


    void Awake()
    {
        playerCtrl=FindObjectOfType<PlayerController>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("car"))
        {
            Debug.Log("triggered");
            Clash();


            
        }

    }

    void Clash()
    {
        playerCtrl.OnEnd();

    }


}



