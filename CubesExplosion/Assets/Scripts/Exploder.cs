using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
     private float _explosionRadius = 10f;
     private float _explosionForce = 50f;

    public void Explode(Cube cube)
    {
        foreach (Rigidbody hit in GetExplodableObjects(cube.transform.position))
        {
            hit.AddExplosionForce(_explosionForce, cube.transform.position, _explosionRadius);
        }
    }

    private List<Rigidbody> GetExplodableObjects(Vector3 position)
    {
        Collider[] hits = Physics.OverlapSphere(position, _explosionRadius);

        List<Rigidbody> explodableObjects = new List<Rigidbody>();

        foreach(Collider hit in hits)
        {
            if (hit.attachedRigidbody != null)
            {
                explodableObjects.Add(hit.attachedRigidbody);
            }
        }

        return explodableObjects;
    } 
}
