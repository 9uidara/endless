using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    [SerializeField] GameObject groundTile;
    [SerializeField] GameObject Coin;
    [SerializeField] GameObject Obstacle;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
       
        temp.GetComponent<GroundTile>().SpawnObstacle();
        temp.GetComponent<GroundTile>().SpawnCoins();

    }
    void Start()
    {
        SpawnTile();
    }

}



