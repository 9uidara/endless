using UnityEngine;

public class GroundTile : MonoBehaviour {

    GroundSpawner groundSpawner;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject obstaclePrefab;

    private void Start () {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
	}
    public void SpawnObstacle()
    {
        // Choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        // Spawn the obstace at the position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }


    public void SpawnCoins()
    {
        // Choose a random point to spawn the obstacle
        int coinsToSpawn = Random.Range(6,8);
        Transform spawnPoint = transform.GetChild(coinsToSpawn).transform;

        // Spawn the obstace at the position
        Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity, transform);
    }
    void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }


}