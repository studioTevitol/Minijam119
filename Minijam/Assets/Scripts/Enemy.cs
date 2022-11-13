using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }

        return health;
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        /*Enemy enemy = collider.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            Debug.Log("hit");
            enemy.TakeDamage(damage);
        }*/
        if (collider.gameObject.CompareTag("Bullet"))
        {
            Die();
            Debug.Log("got hit");
        }

    }
        
    void Die()
    {
        Destroy(gameObject);
    }
}
