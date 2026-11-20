
using UnityEngine;

public class SurfaceDetector : MonoBehaviour
{
    public string CurrentSurface { get; private set; } = "Grass";

    private void OnTriggerEnter2D(Collider2D other)
    {
        CurrentSurface = other.gameObject.name.Replace("Surface_", "");
        Debug.Log("Surface: " + CurrentSurface);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CurrentSurface = "Grass";
        Debug.Log("Surface: Grass");
    }
}
