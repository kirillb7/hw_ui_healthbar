using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealthButton : MonoBehaviour
{
    [SerializeField] private HealthCounter _counter;
    [SerializeField] private int _value = 0;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeHealth);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeHealth);
    }

    private void ChangeHealth()
    {
        if (_value > 0)
        {
            _counter.Heal(_value);
        }
        else
        {
            _counter.Damage(-_value);
        }
    }
}
