using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        //Debug.Log(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "firstScene")
        {
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * 0.12f, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left * 0.08f, ForceMode.Impulse);// .12f in scene1 .08f in scene2
            }
        }

        if (SceneManager.GetActiveScene().name == "SecondScene")
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.right * 0.09f, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.left * 0.09f, ForceMode.Impulse);// .12f in scene1 .08f in scene2
            }
        }

        if (SceneManager.GetActiveScene().name == "Torii")
        {
            if (Input.GetKey(KeyCode.W))
            {
                //Debug.Log(rb.GetComponent<Transform>().position.z);
                rb.AddForce(Vector3.forward * 0.09f, ForceMode.Impulse);
            }
            if (rb.GetComponent<Transform>().position.z > 25.2f)
            {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
