using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;

    private int _spawnCountMin = 2;
    private int _spawnCountMax = 6;
    private float _scaleDivider = 2f;
    private float _splitChanceDivider = 2f;

    public IEnumerable<Rigidbody> Spawn(Cube cube)
    {
        int cubeCount = Random.Range(_spawnCountMin, _spawnCountMax + 1);

        float newSplitChance = cube.CurrentSplitChance / _splitChanceDivider;
        Vector3 newSize = cube.transform.localScale / _scaleDivider;

        List<Rigidbody> newCubes = new();

        for (int i = 0; i < cubeCount; i++)
        {
            Cube newCube = Instantiate(_cubePrefab, cube.transform.position, Quaternion.identity);
            newCube.Setup(newSplitChance, newSize);
            newCubes.Add(newCube.Rigidbody);
        }

        return newCubes;
    }   
}

