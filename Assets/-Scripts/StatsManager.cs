using UnityEngine;

public class StatsManager : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Experience experience;

    private void OnEnable()
    {
        experience.OnLevelUp += Experience_OnLevelUp;
    }
    private void OnDisable()
    {
        experience.OnLevelUp -= Experience_OnLevelUp;
    }
    
    public void Heal(float healAmount)
    {

    }

    private void Experience_OnLevelUp()
    {
        health.ResetHealth();
    }

}