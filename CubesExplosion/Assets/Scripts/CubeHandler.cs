using UnityEngine;

public class CubeInteractionHandler : MonoBehaviour
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
        if (UnityEngine.Random.value <= cube.CurrentSplitChance)
        {
            _spawner.Spawn(cube);
            _exploder.Explode(cube);
            
        }

        Destroy(cube.gameObject);
    }
}