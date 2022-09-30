using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{

    Rigidbody rigidbody;
    Vector3 unitVecY;
    // Start is called before the first frame update
    void Start()
    {
        unitVecY = new Vector3(0, 25, 0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddTorque(unitVecY);
    }
}
