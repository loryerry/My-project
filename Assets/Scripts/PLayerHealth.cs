using UnityEngine;

public class PLayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        healthBar.slider.value = currentHealth;
    }
    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
