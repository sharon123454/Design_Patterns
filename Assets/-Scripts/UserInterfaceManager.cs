using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    [SerializeField] private UI_Health health;
    [SerializeField] private UI_Experiance experiance;

    private void OnEnable()
    {
        //experience.OnAnyLevelUp += Experience_OnAnyLevelUp;
    }
    private void OnDisable()
    {
        //experience.OnAnyLevelUp -= Experience_OnAnyLevelUp;
    }

}