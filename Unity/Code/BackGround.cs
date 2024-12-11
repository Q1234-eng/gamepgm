using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play(); // 배경음악 재생
        }
    }

    public void StopMusic()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop(); // 배경음악 정지
        }
    }
}
