using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Slerp(this.transform.position, this.transform.position + new Vector3(Random.Range(0, .1f), 0, Random.Range(0f, .05f)) * .3f * Time.deltaTime, .8f);

    }
}
