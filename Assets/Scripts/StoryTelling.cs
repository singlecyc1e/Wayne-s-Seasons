using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTelling : MonoBehaviour
{
    public Transition fade;
    public GameObject story;
    public GameObject b;
    public GameObject c;
    bool first = true;
    bool wink = false;
    public GameObject lefteye;
    public GameObject righteye;
    public GameObject sleepleft;
    public GameObject sleepright;
    public Rigidbody snowman;
    // Start is called before the first frame update
    void Start()
    {
        fade.isIN = true;
        snowman.constraints = RigidbodyConstraints.FreezePositionX;
        StartCoroutine(waitfor11seconds());
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!first) { StartCoroutine(storyend());}
        if (wink) { StartCoroutine(Openeyes()); }
    }

    IEnumerator waitfor11seconds()
    {
        yield return new WaitForSeconds(10f);
        fade.isIN = false;
        first = false;
    }

    IEnumerator storyend()
    {
        first = true;
        yield return new WaitForSeconds(2.5f);
        story.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        fade.isIN = true;
        wink = true;
    }

        IEnumerator Openeyes()
    {
        
        yield return new WaitForSeconds(2f);
        sleepleft.SetActive(false);
        sleepright.SetActive(false);
        lefteye.SetActive(true);
        righteye.SetActive(true);
        wink = false;
        snowman.constraints = RigidbodyConstraints.FreezePositionZ;
    }
}
