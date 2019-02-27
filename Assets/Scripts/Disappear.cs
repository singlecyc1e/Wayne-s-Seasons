using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.transform.position); 
        if (transform.position.x > 23.1f) {Destroy(this.gameObject); }
    }
}
