using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private HealthCounter _counter;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        StartCoroutine(UpdateValue());
    }

    private IEnumerator UpdateValue()
    {
        while (enabled)
        {
            _slider.value = _counter.Health;
            _slider.maxValue = _counter.MaxHealth;

            yield return null;
        }
    }
}
