using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager1 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "firstScene")
        {
           // Debug.Log(target.GetComponent<Transform>().position.x);
            if (target.GetComponent<Transform>().position.x > -16.5f) { SceneManager.LoadScene("SecondScene"); }
        }
        if (SceneManager.GetActiveScene().name == "SecondScene")
        {
             //Debug.Log(target.GetComponent<Transform>().position.x);
            if (target.GetComponent<Transform>().position.x < -8f) { SceneManager.LoadScene("train_demo"); }
        }
        if (SceneManager.GetActiveScene().name == "ThirdScene")
        {
            if (target.GetComponent<Transform>().position.x > 26.5f) { SceneManager.LoadScene("Torii"); }
        }
    }
}
