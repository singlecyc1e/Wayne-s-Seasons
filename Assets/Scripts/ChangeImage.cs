using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    private float Counter = 120;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Counter += .20f;
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(1920,Counter);
        }
    }
}
