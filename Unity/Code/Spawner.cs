using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject monsterPrefab; // 생성할 몬스터 프리팹
    public Transform[] spawnPoints; // 몬스터가 생성될 위치들
    public float spawnInterval = 2f; // 몬스터 생성 간격(초)

    private float timer; // 시간 추적용 변수


    void Update()
    {
        // 시간이 경과하면 몬스터를 생성
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnMonster();
            timer = 0f; // 타이머 초기화
        }
    }

    void SpawnMonster()
    {
        // 랜덤한 위치에서 몬스터 생성
        if (spawnPoints.Length > 0)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length); // 랜덤한 위치 선택
            Instantiate(monsterPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
        }
    }
}
