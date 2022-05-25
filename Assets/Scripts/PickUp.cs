using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform rHand;
    private bool connected;
    public BoxCollider col;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("picking up");
            Debug.Log(other.name);
            this.transform.position = rHand.position;
            this.transform.SetParent(rHand);
            connected = true;
        }
    }
    private void Update()
    {
        if (connected)
        {
            rb.useGravity = false;
            this.transform.position = rHand.position;
        }
    }
}
