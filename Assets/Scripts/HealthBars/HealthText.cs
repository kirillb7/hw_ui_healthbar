using UnityEngine;
using TMPro;

public class HealthText : HealthDisplay
{
    [SerializeField] private TextMeshProUGUI _display;

    protected override void OnChanged(int newValue, int newMaxValue)
    {
        _display.text = $"{newValue}/{newMaxValue}";
    }
}
