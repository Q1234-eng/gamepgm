using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // 싱글톤 인스턴스
    public GameObject playerPrefab; // 플레이어 프리팹
    private GameObject currentPlayer; // 현재 플레이어 인스턴스

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // 중복 GameManager 방지
        }
    }

    public void RestartGame()
    {
        Debug.Log("Restarting the game...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 현재 씬 다시 로드
    }

    public void RespawnPlayer(Vector3 spawnPosition)
    {
        // 플레이어 재생성
        if (playerPrefab != null)
        {
            currentPlayer = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Player prefab is not assigned in the GameManager.");
        }
    }
}
