using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    private float Counter = 120;
    public GameObject words;
    public GameObject presentwords;
    public GameObject transition;
    public GameObject firstpart;
    bool presentisOn = false;
    bool lastbegin = false;
    bool firsttime = true;

    private void Start()
    {
        presentwords.SetActive(false);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Counter += .205f;
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(1920,Counter);
        }

        if (this.GetComponent<RectTransform>().rect.height > 539 && firsttime) {
            words.SetActive(true);
            firsttime = false;
            if (this.gameObject.name == "DOWN") {  StartCoroutine(GoEnd()); }
        }

        

        if (presentisOn)
        {
            presentisOn = false;
            StartCoroutine(present());
        }

        if (lastbegin)
        {
            lastbegin = false;
            StartCoroutine(last());
        }
            
    }

    IEnumerator GoEnd()
    {
        yield return new WaitForSeconds(1.5f);
        transition.GetComponent<TransitionBlack>().isIN = true;
        presentisOn = true;

    }

    IEnumerator present()
    {
        yield return new WaitForSeconds(4);
        transition.GetComponent<TransitionBlack>().isIN = false;
        lastbegin = true;
    }

    IEnumerator last()
    {
        yield return new WaitForSeconds(2);
        firstpart.SetActive(false);
        presentwords.SetActive(true);
        transition.GetComponent<TransitionBlack>().isIN = true;
    }
}
