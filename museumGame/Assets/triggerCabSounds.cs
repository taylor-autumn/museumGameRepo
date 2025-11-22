using UnityEngine;

public class triggerCabSounds : MonoBehaviour
{
    public AudioSource cab1;
    public AudioSource cab2;
    public AudioSource cab3;
    public AudioSource cab4;
    public AudioSource cab5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playCabaret();
        }
    }

    public void playCabaret()
    {
        if (!cab1.isPlaying && !cab2.isPlaying && !cab3.isPlaying && !cab4.isPlaying && !cab5.isPlaying)
        {
            print("STARTING PLAY");
            cab1.Play();
            cab2.Play();
            cab3.Play();
            cab4.Play();
            cab5.Play();
        }
        else
        {
            print("Already Playing Bitch");
        }
    }

}
