using System.Collections;
using UnityEngine;
using TMPro;

public class HealthBarText : HealthBar
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override IEnumerator UpdateValue()
    {
        while (enabled)
        {
            _text.text = $"{Counter.Health}/{Counter.MaxHealth}";

            yield return null;
        }
    }
}
