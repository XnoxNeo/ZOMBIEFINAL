using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [Header("Factories")]
    [SerializeField] private List<AbstractFactory> factoryList;


    [SerializeField] private List<Transform> spawnPoints;
    

    public int enemiesPerWave = 5;
    public float timeBetweenWaves = 5f;
    public int currentWave = 0;
    private bool waveAvailable = true;

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    private void Update()
    {
        
        

    }

    private IEnumerator SpawnWaves()
    {
        while (waveAvailable)
        {
            yield return new WaitForSeconds(timeBetweenWaves);

            for (int i = 0; i < enemiesPerWave; i++)
            {
                SpawnEnemy();
            }
            currentWave++;
            
        }
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(0f, 5f), Random.Range(0f, 5f), 0);

        int random = Random.Range(0, factoryList.Count);
        int random2 = Random.Range(0, spawnPoints.Count);

        Enemy enemy = factoryList[(int)random].CreateEnemy(spawnPoints[random2].position + spawnPosition);
        
    }

}
