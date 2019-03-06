using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowThird : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    Vector3 distancevector;
    private bool state = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(target.transform.position);
        if (target.transform.position.x > -8.5f && target.transform.position.x < 5f)
        {
            if (state) { distancevector = this.transform.position - target.GetComponent<Transform>().position; state = false; }
            this.transform.position = Vector3.Slerp(this.transform.position, target.GetComponent<Transform>().position + distancevector, 1f);

        }
    }
}
