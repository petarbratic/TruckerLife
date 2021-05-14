using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFloat : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    private bool floatup;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        floatup = false;
    }

    // Update is called once per frame
    void Update()
    {
        floatingUp();
    }

    private void floatingUp()
    {
        rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
    }

}
