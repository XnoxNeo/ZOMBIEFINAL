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
        if(currentWave > 5)
        {
            currentWave = 0;
        }
        

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
        Vector2 spawnPosition = new Vector2(Random.Range(0f, 5f), Random.Range(0f, 5f));

        int random = Random.Range(0, factoryList.Count);
        Enemy enemy = factoryList[(int)random].CreateEnemy(spawnPosition);
        
    }

}
