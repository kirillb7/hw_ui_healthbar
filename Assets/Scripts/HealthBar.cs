using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private HealthCounter _counter;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed = 0f;

    private float _currentValue = 0;
    private float _currentMaxValue = 0;

    private void Start()
    {
        StartCoroutine(UpdateValue());
    }

    private IEnumerator UpdateValue()
    {
        while (enabled)
        {
            if (_speed > 0)
            {
                _currentValue = Mathf.MoveTowards(_currentValue, _counter.Health, Mathf.Abs((int)_currentValue - _counter.Health) * _speed);
                _currentMaxValue = Mathf.MoveTowards(_currentMaxValue, _counter.MaxHealth, Mathf.Abs((int)_currentMaxValue - _counter.MaxHealth) * _speed);
            }
            else
            {
                _currentValue = _counter.Health;
                _currentMaxValue = _counter.MaxHealth;
            }

            if (_slider != null)
            {
                _slider.value = _currentValue;
                _slider.maxValue = _currentMaxValue;
            }

            if (_text != null)
            {
                _text.text = $"{(int)_currentValue}/{(int)_currentMaxValue}";
            }

            yield return null;
        }
    }
}
