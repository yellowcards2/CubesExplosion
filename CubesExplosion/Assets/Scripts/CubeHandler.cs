using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractionHandler : MonoBehaviour
{
    [SerializeField] private Raycaster _raycaster;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Exploder _exploder;

    private List<Rigidbody> rigidBodies = new();

    private void OnEnable()
    {
        _raycaster.Hited += HandleHit;
    }

    private void OnDisable()
    {
        _raycaster.Hited -= HandleHit;
    }

    private void HandleHit(Cube cube)
    {
        if (UnityEngine.Random.value <= cube.CurrentSplitChance)
        {
            IEnumerable<Rigidbody> rigidbodies = _spawner.Spawn(cube.transform.position, cube.transform.localScale, cube.CurrentSplitChance);
            _exploder.Explode(rigidBodies, cube.transform.position);
        }

        Destroy(cube.gameObject);
    }
}