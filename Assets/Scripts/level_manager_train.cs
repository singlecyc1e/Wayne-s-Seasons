using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_manager_train : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(target.GetComponent<Transform>().position.x);
        if (target.GetComponent<Transform>().position.x < -50f)
        { SceneManager.LoadScene("ThirdScene"); }
    }
}
