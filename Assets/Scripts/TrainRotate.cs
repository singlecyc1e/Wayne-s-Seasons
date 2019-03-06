using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainRotate : MonoBehaviour
{
    private float rotationangle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localEulerAngles = new Vector3(rotationangle, 0, 0); rotationangle += 220 * Time.deltaTime;
    }
}
