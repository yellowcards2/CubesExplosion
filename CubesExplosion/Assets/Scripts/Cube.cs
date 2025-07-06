using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]

public class Cube : MonoBehaviour
{
    private const float MaxSplitChance = 1f;

    public Rigidbody Rigidbody { get; private set; }
    public float CurrentSplitChance { get; private set; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
        CurrentSplitChance = MaxSplitChance;
    }

    public void Setup(float splitChance, Vector3 scale)
    {
        CurrentSplitChance = splitChance;
        transform.localScale = scale;
    }
}