using UnityEngine;
using System;

public class Raycaster : MonoBehaviour
{
    public event Action<Cube> Hited;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.TryGetComponent(out Cube cube))
                    Hited?.Invoke(cube);

            }
        }
    }
}