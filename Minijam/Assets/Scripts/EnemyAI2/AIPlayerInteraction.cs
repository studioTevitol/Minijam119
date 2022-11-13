using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayerInteraction : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            PlayerDeath();
        }
    }

    public void PlayerDeath()
    {
        Debug.Log("DEATH");
    }
}
