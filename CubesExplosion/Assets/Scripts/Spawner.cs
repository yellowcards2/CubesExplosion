using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int _spawnCountMin = 2;
    private int _spawnCountMax = 6;
    private int _divider = 2;
    private float _splitChance = 2f;

    public void Spawn(Cube cube)
    {
        int count = Random.Range(_spawnCountMin, _spawnCountMax + 1);

        Vector3 newScale = cube.transform.localScale / _divider;
        float newSplitChance = cube.CurrentSplitChance / _splitChance;


        for (int i = 0; i < count; i++)
        {
            Cube newCube = Instantiate(cube, cube.transform.position + Vector3.right * 2, Quaternion.identity);
            newCube.Setup(newScale, newSplitChance);
        }
    }
}

