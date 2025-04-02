using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float drain = 2f;

    private float currentHealth = 0;

    private void Awake()
    {
        ResetHealth();
    }

    public void ResetHealth() { currentHealth = maxHealth; }
    public float GetHealth() { return currentHealth; }
    public void Heal(float healAmount)
    {
        if (GetHealth() + healAmount <= maxHealth)
        {
            currentHealth += healAmount;
        }
        else
        { ResetHealth(); }
    }
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
    }

}