using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // 플레이어 Transform
    public float moveSpeed = 3f; // 적 이동 속도
    public int health = 2; // 적 체력
    public GameObject deathEffectPrefab; // 적 사망 이펙트 프리팹
    private SpriteRenderer spriteRenderer; // 적의 스프라이트 렌더러

    void Start()
    {
        // 플레이어 오브젝트를 찾고 Transform을 설정
        if (player == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                player = playerObject.transform;
            }
            else
            {
                Debug.LogError("Player 오브젝트를 찾을 수 없습니다. 태그가 설정되었는지 확인하세요.");
            }
        }

        // SpriteRenderer 컴포넌트 가져오기
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (player != null)
        {
            // 플레이어의 위치를 따라 이동
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // 플레이어 방향에 따라 스프라이트 뒤집기
            if (direction.x > 0)
            {
                spriteRenderer.flipX = false; // 플레이어가 오른쪽에 있으면 기본 방향
            }
            else if (direction.x < 0)
            {
                spriteRenderer.flipX = true; // 플레이어가 왼쪽에 있으면 뒤집기
            }
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
