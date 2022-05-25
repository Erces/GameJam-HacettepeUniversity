using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Mektup : MonoBehaviour
{
    public GameObject ui;

    public AudioSource source;
    public AudioClip clip;
    public Volume volume;
    public VolumeProfile profile;
    public bool isReading;
    public DoorScene door;
    void Start()
    {
        door.enabled = false;
        isReading = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag != "Player")
        {
            return;
           
        }
        ui.SetActive(true);
        if (Input.GetKey(KeyCode.F) && !isReading)
        {
            
            isReading = true;
            Destroy(ui);
            source.PlayOneShot(clip);
            Invoke("changeVolume", 20);

        }
    }
    public void changeVolume()
    {
        door.enabled = true;
        volume.profile = profile;
    }
}
