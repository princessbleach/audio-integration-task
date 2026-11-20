
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int crystalsCollected = 0;
    public int targetCrystals = 10;

    public TextMeshProUGUI counterText;

    void Start()
    {
        UpdateCounter();
    }

    public void CollectCrystal()
    {
        crystalsCollected++;
        UpdateCounter();

        Debug.Log("Crystals: " + crystalsCollected);

        if (crystalsCollected >= targetCrystals)
{
    Debug.Log("YOU WIN!");
    AkSoundEngine.PostEvent("Play_Victory", gameObject);
}
    }

    void UpdateCounter()
    {
        counterText.text = "Crystals: " +
            crystalsCollected + " / " + targetCrystals;
    }
}
