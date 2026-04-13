using UnityEngine;

public class FloorMusic : MonoBehaviour
{
    private AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            music.Play();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            music.Stop();
    }
}
