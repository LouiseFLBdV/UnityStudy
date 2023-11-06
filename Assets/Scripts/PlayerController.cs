using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forcePower = 10;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * forcePower, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce((other.transform.position - transform.position), ForceMode.Impulse);
        }
    }
}