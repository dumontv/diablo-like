using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    public delegate void OnMouseLeftClickHandler(Vector2 pos);
    public event OnMouseLeftClickHandler OnMouseLeftClick;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            OnMouseLeftClick(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }          
    }
}
