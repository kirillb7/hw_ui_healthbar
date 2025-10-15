using System.Collections;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] protected HealthCounter Counter;

    private void Start()
    {
        StartCoroutine(UpdateValue());
    }

    protected virtual IEnumerator UpdateValue()
    {
        while (enabled)
        {
            yield return null;
        }
    }
}
