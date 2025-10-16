using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] protected HealthCounter Counter;

    private void OnEnable()
    {
        Counter.Changed += OnChanged;
    }

    private void OnDisable()
    {
        Counter.Changed -= OnChanged;
    }

    protected virtual void OnChanged(int newValue, int newMaxValue)
    {

    }
}
