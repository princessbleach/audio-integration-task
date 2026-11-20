
using UnityEngine;

public class FootstepAudio : MonoBehaviour
{
    public float footstepInterval = 0.4f;

    private SurfaceDetector surfaceDetector;
    private float footstepTimer;

    void Start()
    {
        surfaceDetector = GetComponent<SurfaceDetector>();
    }

    void Update()
    {
        bool isMoving = Input.GetAxisRaw("Horizontal") != 0 ||
                        Input.GetAxisRaw("Vertical") != 0;

        if (isMoving)
        {
            footstepTimer += Time.deltaTime;

            if (footstepTimer >= footstepInterval)
            {
                PlayFootstep();
                footstepTimer = 0f;
            }
        }
        else
        {
            footstepTimer = 0f;
        }
    }

    void PlayFootstep()
    {
        AkSoundEngine.SetSwitch(
            "SurfaceType",
            surfaceDetector.CurrentSurface,
            gameObject
        );

        AkSoundEngine.PostEvent("Play_Footstep", gameObject);

        Debug.Log("Wwise Footstep: " + surfaceDetector.CurrentSurface);
    }
}
