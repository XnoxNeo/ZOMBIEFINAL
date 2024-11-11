using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text health;
    [SerializeField] private TMP_Text wave;

    private HealthSystem healthSystem;
    private WaveManager waveManager;
    //private GameManager gameManager;

    private void Awake()
    {
        healthSystem = GameObject.FindWithTag("Player").GetComponent<HealthSystem>();
        waveManager = GameObject.FindAnyObjectByType<WaveManager>().GetComponent<WaveManager>();
        //scoreText.text = GetComponent<TMP_Text>().text;
        //health.text = GetComponent<TMP_Text>().text;
        

    }
    private void Start()
    {
        //gameManager = GameManager.Instance;

    }
    private void Update()
    {

        scoreText.text = GameManager.Instance.score.ToString();
        health.text = healthSystem.CurrentHealth.ToString();
        wave.text = waveManager.currentWave.ToString();


    }
}
