using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolmanager : MonoBehaviour
{
    // 프리팹들 보관 변수
    public GameObject[] prefabs;

    // 풀 담당을 하는 리스트
    private List<GameObject>[] pools;

    void Awake()
    {
        // 풀 초기화
        pools = new List<GameObject>[prefabs.Length];

        for (int index = 0; index < pools.Length; index++)
        {
            pools[index] = new List<GameObject>();
        }

        Debug.Log($"Initialized {pools.Length} pools.");
    }

    public GameObject Get(int index)
    {
        if (index < 0 || index >= pools.Length)
        {
            Debug.LogError("Invalid pool index!");
            return null;
        }

        GameObject select = null;

        // 선택한 풀의 놀고 있는 게임오브젝트 검색
        foreach (GameObject item in pools[index])
        {
            if (!item.activeSelf)
            {
                select = item;
                select.SetActive(true);
                break;
            }
        }

        // 놀고 있는 오브젝트를 찾지 못했다면 새로 생성
        if (select == null)
        {
            select = Instantiate(prefabs[index], transform);
            pools[index].Add(select);
        }

        return select;
    }
}
