using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
     private float _explosionRadius = 10f;
     private float _explosionForce = 1000f;

    public void Explode(List<Rigidbody> rigidBodies)
    {
        foreach (Rigidbody  rigidBody in rigidBodies)
        {
            rigidBody.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
        }
    }  
}
