using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]

public class Cube : MonoBehaviour
{
    private float _maxSplitChance = 1f;
    private float _currentSplitChance;

    public float CurrentSplitChance => _currentSplitChance;

    private void Awake()
    {
        _currentSplitChance = _maxSplitChance;
    }

    public void Setup(float splitChance)
    {
        _currentSplitChance = splitChance;
    }
}
