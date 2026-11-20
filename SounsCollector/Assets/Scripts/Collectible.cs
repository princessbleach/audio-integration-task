using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AkSoundEngine.PostEvent("Play_Pickup", gameObject);

            FindFirstObjectByType<GameManager>().CollectCrystal();

            Destroy(gameObject);
        }
    }
}
