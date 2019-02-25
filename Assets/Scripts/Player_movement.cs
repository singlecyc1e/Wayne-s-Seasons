using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            rb.AddForce(Vector3.right * 0.12f, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * 0.12f, ForceMode.Impulse);
        }
    }
}
