using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTurning : MonoBehaviour
{
    public float speed = 2f;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.GetComponent<Transform>().position - transform.position;
        //float angle_x = Mathf.Atan(direction.z) * Mathf.Rad2Deg;
        float angle_y = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        //Debug.Log(transform.localEulerAngles);
        //Quaternion rotation_x = Quaternion.LookRotation(direction, transform.localEulerAngles);//AngleAxis(angle_x,Vector3.back); // ?
        transform.localEulerAngles = new Vector3(0, angle_y - 128, -4);
            
        //transform.rotation = Quaternion.Slerp(transform.rotation,rotation_x,speed * Time.deltaTime);

    }
}
