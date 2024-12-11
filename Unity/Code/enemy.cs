using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // 플레이어 Transform
    public float moveSpeed = 3f; // 적 이동 속도
    public int health = 2; // 적 체력
    public GameObject deathEffectPrefab; // 적 사망 이펙트 프리팹

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log($"Enemy took {damage} damage. Remaining health: {health}");

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (deathEffectPrefab != null)
        {
            Instantiate(deathEffectPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage(1);
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Player"))
        {
            Player playerComponent = collision.GetComponent<Player>();
            if (playerComponent != null)
            {
                Debug.Log("Player collided with Enemy!");
                playerComponent.TakeDamage(1); // 플레이어에게 데미지
            }
        }
    }
}
