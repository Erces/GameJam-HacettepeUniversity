using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knock : MonoBehaviour
{
    public AudioClip knock;
    public AudioSource source;
    public GameObject ui;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if(other.tag == "Player" && Input.GetKeyDown(KeyCode.F))
        {
            source.PlayOneShot(knock);
            ui.SetActive(false);
            Destroy(this);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            ui.SetActive(false);
        }
    }
}
