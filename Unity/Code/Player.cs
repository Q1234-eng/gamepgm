using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Vector2 inputVec; // 입력 벡터
    public float speed = 5f; // 이동 속도
    public GameObject bulletPrefab; // 총알 프리팹
    public GameObject deathEffectPrefab; // 사망 이펙트 프리팹

    public int health = 3; // 플레이어의 초기 체력
    public TextMeshProUGUI healthText; // 체력 표시용 텍스트
    public TextMeshProUGUI gameOverText; // Game Over 텍스트
    public Button restartButton; // Restart 버튼
    public AudioClip gunshotSound; // 총소리 클립
    public AudioClip deathSound; // 사망 소리 클립

    private Rigidbody2D rigid;
    private SpriteRenderer spriter;
    private Animator anim;
    private AudioSource audioSource;

    void Awake()
    {
        // 컴포넌트 초기화
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        // UI 초기화
        if (healthText != null)
        {
            healthText.text = $"Health: {health}"; // 체력 표시 초기화
        }

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false); // Game Over 텍스트 숨김
        }

        if (restartButton != null)
        {
            restartButton.gameObject.SetActive(false); // Restart 버튼 숨김
            restartButton.onClick.AddListener(RestartGame); // Restart 버튼에 이벤트 연결
        }
    }

    void Update()
    {
        // 이동 입력 처리
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");

        // 애니메이션 처리
        anim.SetFloat("Speed", inputVec.magnitude);

        // 스프라이트 방향 변경
        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0; // 좌우 반전
        }

        // 총알 발사 처리
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
            PlayGunshotSound();
        }
    }

    void FixedUpdate()
    {
        // 이동 처리
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
    }

    public void TakeDamage(int damage)
    {
        // 체력 감소
        health -= damage;

        // 체력 UI 업데이트
        if (healthText != null)
        {
            healthText.text = $"Health: {health}";
        }

        Debug.Log($"Player took {damage} damage. Remaining health: {health}");

        // 체력이 0 이하가 되면 사망 처리
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // 사망 이펙트 생성
        if (deathEffectPrefab != null)
        {
            Instantiate(deathEffectPrefab, transform.position, Quaternion.identity);
        }

        // 사망 소리 재생
        if (deathSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(deathSound);
        }

        // 게임 오버 처리
        GameOver();

        // 플레이어 오브젝트 삭제
        Destroy(gameObject);
    }

    void FireBullet()
    {
        if (bulletPrefab != null)
        {
            // 발사 방향 설정
            Vector2 direction = inputVec.normalized;
            if (direction == Vector2.zero)
            {
                direction = spriter.flipX ? Vector2.left : Vector2.right;
            }

            // 총알 생성 위치
            Vector3 bulletSpawnPosition = transform.position + new Vector3(direction.x * 0.5f, direction.y * 0.5f, 0);

            // 총알 생성
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition, Quaternion.identity);

            // 총알 방향 설정
            Bullet bulletScript = bullet.GetComponent<Bullet>();
            if (bulletScript != null)
            {
                bulletScript.SetDirection(direction);
            }
        }
    }

    void PlayGunshotSound()
    {
        // 총소리 재생
        if (gunshotSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(gunshotSound);
        }
    }

    void GameOver()
    {
        // Game Over 텍스트 활성화
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }

        // Restart 버튼 활성화
        if (restartButton != null)
        {
            restartButton.gameObject.SetActive(true);
        }
    }

    public void RestartGame()
    {
        // 씬 재시작
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
