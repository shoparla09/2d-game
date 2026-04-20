using UnityEngine;

public class SC_2DCoin : MonoBehaviour
{
    public int coinCount;
    public GameObject coinSpawnPoint;
    public GameObject[] coinPrefabs;

    void Start()
    {
        SpawnCoin();
    }

    void SpawnCoin()
    {
        int randomIndex = Random.Range(0, coinPrefabs.Length);

        GameObject coin = Instantiate(
            coinPrefabs[randomIndex],
            coinSpawnPoint.transform.position,
            coinSpawnPoint.transform.rotation
        );
    }
}

