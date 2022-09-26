using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource footSteps;
    void Start()
    {
        footSteps = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            footSteps.Play();
        }
        

        
    }
}
