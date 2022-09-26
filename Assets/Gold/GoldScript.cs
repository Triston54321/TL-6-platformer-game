using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{
    public AudioSource collect;
    // Start is called before the first frame update
    void Start()
    {
        collect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnTriggerEnter2D(Collider2D myGold)
    {
        if (myGold.tag == "myGold")
        {
            collect.Play();
        }
    }
}
