using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        Change();    
    }

    private void Change()
    {
        _renderer.material.color = Random.ColorHSV();
    }
}
