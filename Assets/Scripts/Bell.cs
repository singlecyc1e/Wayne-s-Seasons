using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    public GameObject train;
    public GameObject trainApproach;
    public GameObject trainHone;
    public GameObject trainLeave;
    public GameObject Snowman;
    public GameObject SnowmanOnTrain;
    public GameObject bell;
    private bool firstplay = true;
    private bool honeplay = true;
    bool firsttime = true;
    // Start is called before the first frame update
    void Start()
    {
        SnowmanOnTrain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //    if (time >= 30f)
        //    {
        //        //Debug.Log("start");
        //       train.GetComponent<Animator>().SetBool("start", true);
        //        if (firstplay) { trainApproach.GetComponent<AudioSource>().Play(); firstplay = false; trainApproach.GetComponent<TrainSoundingEffect>().myswitch = true; }
        //       if (time >= 44f && honeplay)
        //       {
        //           Snowman.SetActive(false);
        //           SnowmanOnTrain.SetActive(true);
        //           trainHone.GetComponent<AudioSource>().Play(); trainLeave.GetComponent<AudioSource>().Play(); honeplay = false;
        //       }
        //    }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (firsttime)
        {
            bell.GetComponent<AudioSource>().Play();
            firsttime = false;
            StartCoroutine(Traincoming());
            StartCoroutine(Trainleave());
        }
    }

    IEnumerator Traincoming()
    {
        yield return new WaitForSeconds(5);
        train.GetComponent<Animator>().SetBool("start", true);
        trainApproach.GetComponent<AudioSource>().Play();
        trainApproach.GetComponent<TrainSoundingEffect>().myswitch = true; 
    }

    IEnumerator Trainleave()
    {
        yield return new WaitForSeconds(19);
        Snowman.SetActive(false);
        SnowmanOnTrain.SetActive(true);
        trainHone.GetComponent<AudioSource>().Play();
        trainLeave.GetComponent<AudioSource>().Play(); 
    }
}
