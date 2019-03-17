using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionBlack : MonoBehaviour
{
    public float trans = 1f;
    public bool isIN = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Image>().color = new Color(0, 0, 0, trans);
        if (isIN) { trans -= 1f * Time.deltaTime; }
        else { trans += 1f * Time.deltaTime; }
        trans = Mathf.Clamp(trans, 0, 1f);
    }
}
