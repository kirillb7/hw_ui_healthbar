using System.Collections;
using UnityEngine;

public class HealthBarSmooth : HealthBar
{
    [SerializeField] private float _speed = 0f;

    private float _currentValue;
    private float _currentMaxValue;
    private int _targetValue;
    private int _targetMaxValue;
    private bool _isUpdating = false;

    protected override void Start()
    {
        base.Start();

        _currentValue = Display.value;
        _currentMaxValue = Display.maxValue;
        _targetValue = Counter.Value;
        _targetMaxValue = Counter.MaxValue;
    }

    protected override void OnChanged(int newValue, int newMaxValue)
    {
        _targetValue = newValue;
        _targetMaxValue = newMaxValue;

        if (_isUpdating == false)
        {
            StartCoroutine(UpdateValue());
        }
    }

    private IEnumerator UpdateValue()
    {
        _isUpdating = true;

        while (_currentValue != _targetValue || _currentMaxValue != _targetMaxValue)
        {
            if (_speed > 0)
            {
                _currentValue = Mathf.MoveTowards(_currentValue, _targetValue, Mathf.Abs((int)_currentValue - _targetValue) * _speed);
                _currentMaxValue = Mathf.MoveTowards(_currentMaxValue, _targetMaxValue, Mathf.Abs((int)_currentMaxValue - _targetMaxValue) * _speed);
            }
            else
            {
                _currentValue = _targetValue;
                _currentMaxValue = _targetMaxValue;
            }

            Display.value = _currentValue;
            Display.maxValue = _currentMaxValue;

            yield return null;
        }

        _isUpdating = false;
    }
}
