using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public int initVel;
    public Collider collider0;
    public Rigidbody rigidbody0;
    void Start()
    {
        collider0  = GetComponent<Collider>();
        rigidbody0 = GetComponent<Rigidbody>();
        rigidbody0.AddForceAtPosition(transform.forward * initVel, transform.position, ForceMode.VelocityChange);
    }
}
