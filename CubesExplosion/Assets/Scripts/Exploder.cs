using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    private float _explosionRadius = 10f;
    private float _explosionForce = 200f;
    private float _upForce = 1f;

    public void Explode(IEnumerable<Rigidbody> explodableObjects)
    {
        foreach (Rigidbody explodableObject in explodableObjects)
        {
            explodableObject.AddExplosionForce(_explosionForce, transform.position, _explosionRadius, _upForce, ForceMode.Impulse);
        }
    }
}
