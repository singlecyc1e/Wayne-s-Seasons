using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotate : MonoBehaviour
{
    public bool isHOUR = false;
    private bool firstplay = true;
    private bool honeplay = true;
    private float time = 0f;
    public GameObject train;
    public GameObject trainApproach;
    public GameObject trainHone;
    public GameObject trainLeave;

    // Update is called once per frame
    void Update()
    {
        if (isHOUR) { this.transform.localEulerAngles = new Vector3(0, 0, time); time += 60 * Time.deltaTime / 60;
            if (time >= 30f) {
                Debug.Log("start");
                train.GetComponent<Animator>().SetBool("start",true);
                if (firstplay) { trainApproach.GetComponent<AudioSource>().Play(); firstplay = false; trainApproach.GetComponent<TrainSoundingEffect>().myswitch = true; }
                if (time >= 44f && honeplay) { trainHone.GetComponent<AudioSource>().Play(); trainLeave.GetComponent<AudioSource>().Play(); honeplay = false; }
            }
        }
        else { this.transform.localEulerAngles = new Vector3(0, 0, time); time += 18 * Time.deltaTime; }
    }
}
