using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Rigidbody bulletRb;
    public float forwardForce;

    private void Start()
    {
        bulletRb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // bulletRb.AddForce(transform.forward * forwardForce);
        transform.Translate(Vector3.forward * forwardForce * Time.deltaTime);
        Destroy(gameObject, 3.0f);
    }
}
