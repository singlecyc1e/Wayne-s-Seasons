using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingScene2 : MonoBehaviour
{
    public Transform target;
    Vector3 distancevector;
    private bool state = true;
    // Update is called once per frame
    private void Start()
    {
        Destroy(GameObject.Find("Sound Manager"));
    }
    void Update()
    {
        //Debug.Log(target.transform.position);
        
        if (target.transform.position.x > 8.5f && target.transform.position.x < 18f ) {
            if (state) { distancevector = this.transform.position - target.GetComponent<Transform>().position; state = false; }
            this.transform.position = Vector3.Slerp(this.transform.position, target.GetComponent<Transform>().position + distancevector, 1f);
            
        }
        if (Input.GetKey(KeyCode.Escape)) { Application.Quit(); }
    }
}
