using System.Collections;
using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{
    [SerializeField] private HealthCounter _counter;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        StartCoroutine(UpdateValue());
    }

    private IEnumerator UpdateValue()
    {
        while (enabled)
        {
            _text.text = $"{_counter.Health}/{_counter.MaxHealth}";

            yield return null;
        }
    }
}
