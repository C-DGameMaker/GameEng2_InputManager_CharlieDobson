using UnityEngine;

public class ShowControls : MonoBehaviour
{
    public GameObject canvas;

    public void ControlsMenu()
    {
        canvas.SetActive(!canvas.activeSelf);
    }
}
