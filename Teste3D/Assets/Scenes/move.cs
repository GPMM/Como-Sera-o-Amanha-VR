using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = this.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rg.AddForce( Vector3.forward * 150);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rg.AddForce(Vector3.back * 150);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rg.AddForce(Vector3.left * 150);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rg.AddForce(Vector3.right * 150);
        }
    }
}
