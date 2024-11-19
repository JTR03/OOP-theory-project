using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemyList;
    [SerializeField] private List<GameObject> objectList;
    public static List<GameObject> gameObjects;

    private float xRange = 16.0f;
    private float spawnRate = 5;

    private int enemyCount = 0;
    private int objectCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObjects = new List<GameObject>(); 
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        while (enemyCount <3)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, enemyList.Count);
            Instantiate(enemyList[index], RandomSpawnPosition(), enemyList[index].transform.rotation);
            enemyCount++;
        }
    }

    IEnumerator SpawnObject()
    {
        while (gameObjects.Count < 5)
        {
            yield return new WaitForSeconds(2);
            int index = Random.Range(0, objectList.Count);
            GameObject crop = Instantiate(objectList[index], RandomSpawnPosition(), objectList[index].transform.rotation);
            gameObjects.Add(crop);
            objectCount++;
        }
    }

    private Vector3 RandomSpawnPosition()
    {
       float z = Random.Range(0, 17);
        float x = Random.Range(-8, xRange);

        Vector3 startPos = new Vector3(x, 0.5f, z);
        return startPos;
    }
}
