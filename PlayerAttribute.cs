using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    public int maxHealth = 100;
    public int maxStamina = 100;
    public int maxMana = 100;
    public int level = 1;
    public int experience = 0;

    private int currentHealth;
    private int currentStamina;
    private int currentMana;

    void Start()
    {
        currentHealth = maxHealth;
        currentStamina = maxStamina;
        currentMana = maxMana;
    }

    void Update()
    {
        // Implement attribute-related logic here if needed (e.g., regeneration)
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Handle player death (e.g., respawn)
        Debug.Log("Player died!");
    }

    public void GainExperience(int amount)
    {
        experience += amount;
        CheckLevelUp();
    }

    void CheckLevelUp()
    {
        // Check if experience is enough for level up
        // For simplicity, let's assume 100 experience per level
        int requiredExperience = level * 100;
        if (experience >= requiredExperience)
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        level++;
        // Add logic for increasing attributes or unlocking skills
        Debug.Log("Level up! New level: " + level);
    }

    public void RestoreHealth(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
    }

    public void RestoreStamina(int amount)
    {
        currentStamina = Mathf.Min(currentStamina + amount, maxStamina);
    }

    public void RestoreMana(int amount)
    {
        currentMana = Mathf.Min(currentMana + amount, maxMana);
    }

    public void ConsumeStamina(int amount)
    {
        currentStamina -= amount;
        if (currentStamina < 0)
        {
            currentStamina = 0;
        }
    }

    public void ConsumeMana(int amount)
    {
        currentMana -= amount;
        if (currentMana < 0)
        {
            currentMana = 0;
        }
    }
}
