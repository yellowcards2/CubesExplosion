using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Cube _cube;

    private int _spawnCountMin = 2;
    private int _spawnCountMax = 6;
    private float _scaleDivider = 2f;
    private float _splitChanceDivider = 2f;

    public IEnumerable<Rigidbody> Spawn(Vector3 position,Vector3 scale, float splitChance)
    {
        List<Rigidbody> rigidbodies = new();

        int count = Random.Range(_spawnCountMin, _spawnCountMax + 1);
        float reducedChance = splitChance / _splitChanceDivider;

        for (int i = 0; i < count; i++)
        {
            Cube cube = Instantiate(_cube, position, Quaternion.identity);
            cube.transform.localScale = scale / _scaleDivider;
            cube.Setup(reducedChance);

            if (cube.TryGetComponent(out Rigidbody rigidbody))
            {
                rigidbodies.Add(rigidbody);
            }
        }

        return rigidbodies;
    }
}

