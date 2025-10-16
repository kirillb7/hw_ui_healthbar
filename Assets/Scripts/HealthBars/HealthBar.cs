using UnityEngine;
using UnityEngine.UI;

public class HealthBar : HealthDisplay
{
    [SerializeField] protected Slider Display;

    protected virtual void Start()
    {
        Display.interactable = false;
        Display.minValue = 0;
        Display.maxValue = Counter.MaxValue;
        Display.value = Counter.Value;
    }

    protected override void OnChanged(int newValue, int newMaxValue)
    {
        Display.value = newValue;
        Display.maxValue = newMaxValue;
    }
}
