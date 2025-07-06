using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]

public class Cube : MonoBehaviour
{
    private const float MaxSplitChance = 1f;


    public bool IsSplitted { get; private set; }
    public Rigidbody Rigidbody { get; private set; }
    public float CurrentSplitChance { get; private set; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
        CurrentSplitChance = MaxSplitChance;
    }

    private void Start()
    {
        IsSplitted = CanSplit();
    }

    public void Setup(float splitChance, Vector3 scale)
    {
        IsSplitted = CanSplit();

        CurrentSplitChance = splitChance;
        transform.localScale = scale;
    }

    private bool CanSplit()
    {
        float minSplitChance = 0f;
        float maxSplitChance = 1f;

        float currentSplitChance = Random.Range(minSplitChance, maxSplitChance);

        return currentSplitChance <= CurrentSplitChance;
    }

}