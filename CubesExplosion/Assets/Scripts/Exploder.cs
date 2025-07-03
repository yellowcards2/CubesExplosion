using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
     private float _explosionRadius = 10f;
     private float _explosionForce = 2000f;

    public void Explode(IEnumerable<Rigidbody> explodableObjects, Vector3 position)
    {
        foreach (Rigidbody  explodableObject in explodableObjects)
        {
            explodableObject.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
        }
    }  
}
