using NUnit.Framework;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    //프리펩들 보관할 변수
    public GameObject[] Prefabs;
    //풀 리스트
    List<GameObject>[] pools;

    private void Awake()
    {
        pools = new List<GameObject>[Prefabs.Length];
        for (int i = 0; i < pools.Length; i++)
        {
            pools[i] = new List<GameObject>();
        }
    }

    public GameObject Get(int index)
    {
        GameObject select = null;
        foreach (GameObject item in pools[index])
        {
            if (!item.activeSelf)
            { 
            select = item;
            select.SetActive(true);
            break;
            }   
        }
        if(select == null)
        {
            select = Instantiate(Prefabs[index], transform);
            pools[index].Add(select);
        }
        return select;
    }
}
