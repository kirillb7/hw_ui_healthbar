using UnityEngine;

public class HealthCounter : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;

    private int _health;

    public int Health => _health;
    public int MaxHealth => _maxHealth;

    private void Start()
    {
        _health = _maxHealth;
    }

    public void Heal(int amount)
    {
        _health = Mathf.Clamp(_health + amount, _health, _maxHealth);
    }

    public void Damage(int amount)
    {
        _health -= amount;
    }
}
