using UnityEngine;

public class Experience : MonoBehaviour
{
    [SerializeField] private int pointsPerLevel = 200;

    public event LevelUpEvent OnLevelUp;
    public delegate void LevelUpEvent();

    private int currentEXP = 0;

    public void GainExperience(int experiencePoints)
    {
        currentEXP += experiencePoints;

        if (GetLevel() > pointsPerLevel)
        {
            OnLevelUp?.Invoke();
        }
    }
    public int GetExperiencePoints() { return currentEXP; }
    public int GetLevel() { return GetExperiencePoints() / pointsPerLevel; }

}