using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : HealthBar
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed = 0f;

    private float _currentValue = 0;
    private float _currentMaxValue = 0;

    protected override IEnumerator UpdateValue()
    {
        while (enabled)
        {
            if (_speed > 0)
            {
                _currentValue = Mathf.MoveTowards(_currentValue, Counter.Health, Mathf.Abs((int)_currentValue - Counter.Health) * _speed);
                _currentMaxValue = Mathf.MoveTowards(_currentMaxValue, Counter.MaxHealth, Mathf.Abs((int)_currentMaxValue - Counter.MaxHealth) * _speed);
            }
            else
            {
                _currentValue = Counter.Health;
                _currentMaxValue = Counter.MaxHealth;
            }

            _slider.value = _currentValue;
            _slider.maxValue = _currentMaxValue;

            yield return null;
        }
    }
}
