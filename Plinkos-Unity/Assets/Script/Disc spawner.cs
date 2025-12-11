using UnityEngine;

public class DiscSpawner : MonoBehaviour
{
    public GameObject normalPrefab;
    public GameObject heavyPrefab;
    public GameObject bouncyPrefab;
    

    public void SpawnNormal()
    {
        Instantiate(normalPrefab, transform.position, Quaternion.identity);
    }

    public void SpawnHeavy()
    {
        Instantiate(heavyPrefab, transform.position, Quaternion.identity);
    }

    public void SpawnBouncy()
    {
        Instantiate(bouncyPrefab, transform.position, Quaternion.identity);
    }

}
