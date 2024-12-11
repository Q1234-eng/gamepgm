using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 moveDirection;

    public void SetDirection(Vector2 direction)
    {
        moveDirection = direction.normalized;
    }

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Bullet hit the enemy!");
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
