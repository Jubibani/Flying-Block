using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance; // Singleton

    [Header("               Audio Source                ")]
    [SerializeField] AudioSource soundEffects;

    [Header("               Audio Clip                ")]
    public AudioClip earnCoinSound;
    public AudioClip flySound;
    public AudioClip hitObstacleSound;

    private void Awake()
    {
        // Ensure only one instance
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void EarnCoinSound()
    {
        soundEffects.PlayOneShot(earnCoinSound);
    }

    public void FlySound()
    {
        soundEffects.PlayOneShot(flySound);
    }


    public void HitObstacleSound()
    {
        soundEffects.PlayOneShot(hitObstacleSound);
    }
}
