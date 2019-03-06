using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainSoundingEffect : MonoBehaviour
{
    private float direction = -1f;
    public bool myswitch = true;

    // Update is called once per frame
    void Update()
    {
        if (true) { // when animation play
            if (myswitch) { direction = -1f; }
            myswitch = false;
            this.GetComponent<AudioSource>().panStereo = direction;
            direction += 1f / 7.5f * Time.deltaTime;
        }
    }
}
