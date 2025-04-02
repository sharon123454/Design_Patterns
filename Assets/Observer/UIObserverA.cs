using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UIObserverA : MonoBehaviour, IObserveEnrage
{
    [SerializeField] private Image enrageFilterImage;
    [SerializeField] private Image afterHitHealthImage;
    [SerializeField] private Image beforeHitHealthImage;
    [SerializeField] private TextMeshProUGUI healthText;

    private WaitForSeconds waitForEnrageEnd = new WaitForSeconds(0);
    private bool isEnraged;

    private void OnEnable()
    {
        EnrageSubject.Instance.OnAnyEnrage += OnEnrageStarted;
    }
    private void OnDisable()
    {
        EnrageSubject.Instance.OnAnyEnrage -= OnEnrageStarted;
    }

    public void OnEnrageStarted(float enrageTime)
    {
        isEnraged = true;
        waitForEnrageEnd = new WaitForSeconds(enrageTime);
        StartCoroutine(EnrageCoroutine());
    }
    public void OnEnrageEnded()
    {
        isEnraged = false;
        print("test- code reached, enrage ended");
    }

    private IEnumerator EnrageCoroutine()
    {
        print("test- code reached, enrage started");
        yield return waitForEnrageEnd;
        OnEnrageEnded();
    }

}