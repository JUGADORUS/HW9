using System;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public event Action Clicked;

    private void OnMouseDown()
    {
        Clicked?.Invoke();
    }
}
