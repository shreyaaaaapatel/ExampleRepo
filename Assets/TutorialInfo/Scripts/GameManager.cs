using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyOnePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 2f, 3f);
    }


    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-3f, 3f), 2.5f, 0), Quaternion.identity);
    }
}
