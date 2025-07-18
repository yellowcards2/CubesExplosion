using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    private float _explosionRadius = 10f;
    private float _explosionForce = 2f;
    private float _upForce = 1f;

    public void Explode(Cube cube)
    {
        foreach (var explodableobjects in GetExplodableObjects(cube.transform))
        {
            explodableobjects.AddExplosionForce(_explosionForce, cube.transform.position, _explosionRadius, _upForce, ForceMode.Impulse);
        }
    }

    private IEnumerable<Rigidbody> GetExplodableObjects(Transform cube)
    {
        Collider[] hits = Physics.OverlapSphere(cube.position, _explosionRadius);
        List<Rigidbody> cubes = new();

        foreach (Collider hit in hits)
        {
            if (hit.attachedRigidbody != null)
            {
                cubes.Add(hit.attachedRigidbody);
            }
        }

        return cubes;
    }
}
