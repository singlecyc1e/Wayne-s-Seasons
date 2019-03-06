using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWestern : MonoBehaviour
{
    public Transform target;
    Vector3 distancevector;
    private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        //distancevector = this.transform.position - target.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.transform.position.x < 10.5f && target.transform.position.x > -20.8f)
        {
            if (state) { distancevector = this.transform.position - target.GetComponent<Transform>().position; state = false; }
            this.transform.position = Vector3.Slerp(this.transform.position, target.GetComponent<Transform>().position + distancevector, 1f);
        //Debug.Log(target.transform.position.x);
        }
        if (Input.GetKey(KeyCode.Escape)) { Application.Quit(); }
    }
}
