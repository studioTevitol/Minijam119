using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 500f;
    public int damage = 25;
    [SerializeField] private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed * Time.deltaTime;
    }

    void Update()
    {
        StartCoroutine(DeleteBullet());
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Enemy enemy = collider.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            Debug.Log("hit");
            enemy.TakeDamage(damage);
        }

    }

    IEnumerator DeleteBullet()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
