using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoFalling : MonoBehaviour
{
    public float left;
    public float right;
    public float forward;
    public float back;
    public float down;
    Vector3 originalPoint;
    int DirectionX = 1;
    // Start is called before the first frame update
    void Start()
    {
        originalPoint = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - originalPoint.x > 2) { DirectionX = 1; }
        if (transform.position.x - originalPoint.x < -2) { DirectionX = -1; }
        this.transform.Translate(Vector3.left * DirectionX * Time.deltaTime * 0.9f);
        this.transform.Translate(Vector3.down * 3.8f *Time.deltaTime * Random.value);
    }
}
