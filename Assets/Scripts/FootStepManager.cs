using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] clips;
    private int random;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Step()
    {
        random = Random.Range(0, clips.Length);
        source.PlayOneShot(clips[1]);
    }
}
