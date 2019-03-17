using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotate : MonoBehaviour
{
    public bool isHOUR = false;
    private float time = 0f;


    void Update()
    {
        if (isHOUR) { this.transform.localEulerAngles = new Vector3(0, 0, time); time += 60 * Time.deltaTime / 60;}
        
        else { this.transform.localEulerAngles = new Vector3(0, 0, time); time += 12 * Time.deltaTime; }
    }
}
