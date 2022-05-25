using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DoorScene : MonoBehaviour
{

    public GameObject ui;
    void Start()
    {
        ui.SetActive(true);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        
        if(Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}
