using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarInstant : HealthBar
{
    [SerializeField] private Slider _slider;

    protected override IEnumerator UpdateValue()
    {
        while (enabled)
        {
            _slider.value = Counter.Health;
            _slider.maxValue = Counter.MaxHealth;

            yield return null;
        }
    }
}
