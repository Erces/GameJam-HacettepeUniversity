using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MhaEnding : MonoBehaviour
{
    public AudioSource source,source2;
    public AudioClip clip,clip2;

    void Start()
    {
        Invoke("ending", 2f);

        Invoke("flame", 2.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ending()
    {
        source.PlayOneShot(clip);
    }
    public void flame()
    {
        source.PlayOneShot(clip2);
    }
}
