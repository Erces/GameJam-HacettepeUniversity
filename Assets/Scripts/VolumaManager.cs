using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class VolumaManager : MonoBehaviour
{

    public static VolumaManager instance;

    public VolumeProfile[] volumelist;
    public Volume ppvolume;
    
    private int counter;
    private void Awake()
    {
        counter = 0;
        if(instance != null)
        {
            Debug.Log("Volume Manager error");
            return;
        }
        instance = this;
    }

    // Update is called once per frame
   public void increaseVolume()
    {
        counter += 1;
        ppvolume.profile = volumelist[counter];
    }
    
}
