using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingParts : MonoBehaviour
{
    public Transform body;
    //Vector3 deltaposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //deltaposition = this.transform.position - 
        this.transform.position = body.position;
    }
}
