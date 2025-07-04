using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]

public class Cube : MonoBehaviour
{
    private const float MaxSplitChance = 1f;

    public float CurrentSplitChance { get; private set; }

    private void Awake()
    {
        CurrentSplitChance = MaxSplitChance;
    }

    public void Setup(float splitChance, Vector3 scale)
    {
        CurrentSplitChance = splitChance;
        transform.localScale = scale;
    }
}