using System.Collections.Generic;
using UnityEngine;

//Если шанс деления меньше чем нужно нужно просто взорвать куб (разбросать ближайшие кубы), 
//иначе заспавнить новые и разбросать только заспавненные.

public class CubeHandler : MonoBehaviour
{
    [SerializeField] private Raycaster _raycaster;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Exploder _exploder;

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

        if (cube.IsSplitted)
        {
            _spawner.Spawn(cube);
        }
        else
        {
            _exploder.Explode(cube);
        }

        Destroy(cube.gameObject);
    }
}