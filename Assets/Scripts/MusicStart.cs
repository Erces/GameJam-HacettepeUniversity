using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    private AudioSource source;
    public AudioClip clip;
    private bool isPlaying;

    void Start()
    {
        source = GetComponent<AudioSource>();
        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"&& !isPlaying)
        {
            isPlaying = true;
            source.PlayOneShot(clip);
        }
    }
}
