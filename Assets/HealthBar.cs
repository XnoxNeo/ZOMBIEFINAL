using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public Slider backHealth;

    public HealthSystem playerHealth;

    public int currentHealth;
    public int currentHealthSlow;

    void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<HealthSystem>();

        healthSlider.maxValue = playerHealth.maxHealth;
        backHealth.maxValue = playerHealth.maxHealth;

        currentHealth = playerHealth.maxHealth;
        currentHealthSlow = playerHealth.maxHealth;

        StartCoroutine(LowerNumberOverTime());
        
    }


    private void Update()
    {
        currentHealth = playerHealth.CurrentHealth;

        if(currentHealthSlow < currentHealth)
        {
            currentHealthSlow = currentHealth;
        }

        UpdateHealthBar(currentHealth, currentHealthSlow);


    }

    private void UpdateHealthBar(int currentHealth, int back)
    {

        healthSlider.value = currentHealth;
        //backHealth.value = back;

    }

    private IEnumerator LowerNumberOverTime()
    {
        while (currentHealthSlow >= currentHealth)
        {
            currentHealthSlow --;
            currentHealthSlow = Mathf.Max(currentHealthSlow, currentHealth);
            backHealth.value = currentHealthSlow;

            yield return new WaitForSeconds(0.01f);



        }
        
    }


}
