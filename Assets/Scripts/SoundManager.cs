using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Singleton instance
    public static SoundManager Instance { get; private set; }

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private AudioClip tabChangeSfx; 

    private void Awake()
    {
        // Implementing singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void PlayTabSfx()
    {
        if (audioSource != null && tabChangeSfx != null)
        {
            audioSource.PlayOneShot(tabChangeSfx);
        }
        else
        {
            Debug.LogWarning("AudioSource or clickSoundEffect is not set on the SoundManager.");
        }
    }
}
