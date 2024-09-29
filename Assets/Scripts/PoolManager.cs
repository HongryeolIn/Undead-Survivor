using NUnit.Framework;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    //������� ������ ����
    public GameObject[] Prefabs;
    //Ǯ ����Ʈ
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
