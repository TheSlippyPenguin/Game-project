using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float force;
    public Vector3 vector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           other.GetComponent<Rigidbody>().AddForce(0,force,0, ForceMode.VelocityChange); ;

        }
    }
}
