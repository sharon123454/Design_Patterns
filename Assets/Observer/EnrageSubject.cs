using UnityEngine;

public class EnrageSubject : MonoBehaviour
{
    public static EnrageSubject Instance;

    [SerializeField] private float enrageTime = 5f;

    public event EnrageCallbackParameters OnAnyEnrage;
    public delegate void EnrageCallbackParameters(float EnrageTime);

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);

        Instance = this;
    }

    void Update()
    {
        //Enrage fabrication
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnAnyEnrage?.Invoke(enrageTime);
        }
    }

}