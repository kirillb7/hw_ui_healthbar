using System;
using UnityEngine;

public class HealthCounter : MonoBehaviour
{
    [SerializeField] private int _maxValue = 100;

    private int _value;

    public event Action<int, int> Changed;

    public int Value => _value;
    public int MaxValue => _maxValue;

    private void Start()
    {
        _value = _maxValue;

        Changed?.Invoke(_value, _maxValue);
    }

    public void Heal(int amount)
    {
        Change(amount);
    }

    public void Damage(int amount)
    {
        Change(-amount);
    }

    private void Change(int amount)
    {
        _value = Mathf.Clamp(_value + amount, 0, _maxValue);

        Changed?.Invoke(_value, _maxValue);
    }
}
