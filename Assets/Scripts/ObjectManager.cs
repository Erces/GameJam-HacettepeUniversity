using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public List<GameObject> warObjects;
    public List<GameObject> dreamObjects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateWarObjects()
    {
        foreach (var obj in dreamObjects)
        {
            obj.SetActive(false);
        }
        foreach (var obj in warObjects)
        {
            obj.SetActive(true);
        }
    }
    public void activateDreamObjects()
    {
        foreach (var obj in dreamObjects)
        {
            obj.SetActive(true);
        }
        foreach (var obj in warObjects)
        {
            obj.SetActive(false);
        }
    }
}
