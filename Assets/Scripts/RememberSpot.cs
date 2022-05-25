using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RememberSpot : MonoBehaviour
{

    public GameObject rememberUI;
    public GameObject rememberAnim;
    public GameObject rememberedObject;
    public AudioSource source;
    public AudioClip clip;
    private bool remembered;
    void Start()
    {
        remembered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" )
        {
            rememberUI.SetActive(true);
            if (Input.GetKey(KeyCode.F) && !remembered)
            {
                remembered = true;
                GameObject remembered2 = (GameObject)Instantiate(rememberedObject, this.transform.position, Quaternion.identity);
                rememberUI.SetActive(false);
                rememberAnim.GetComponent<Animator>().SetTrigger("Remember");
                VolumaManager.instance.increaseVolume();
                source.PlayOneShot(clip);
                Destroy(this);
            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            rememberUI.SetActive(false);

        }
    }
}
