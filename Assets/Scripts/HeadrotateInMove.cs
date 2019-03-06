using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadrotateInMove : MonoBehaviour
{
    public float speed = 2f;
    Quaternion rotation_x;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = target.GetComponent<Transform>().position - transform.position;
        //float angle_x = Mathf.Atan(direction.z) * Mathf.Rad2Deg;
        //float angle_y = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        Debug.Log(transform.localEulerAngles);

        if (Input.GetKey(KeyCode.A)) { transform.Rotate(new Vector3(0, 1, 0)); }
        else if (Input.GetKey(KeyCode.D)) { transform.Rotate(new Vector3(0, -1, 0)); }
        //transform.localEulerAngles = new Vector3(0, angle_y - 128, -4);
        float max = Mathf.Clamp(transform.localEulerAngles.y,16f,155f);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, max, transform.localEulerAngles.z);
            
    }
}
