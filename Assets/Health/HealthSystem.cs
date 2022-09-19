using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }


  
    // Update is called once per frame
    void Update()
    {
        if(dead == true)
        {
            //will need a game over menu with restart?
        }
    }


    //if collision between bat and player

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bat")
        {
            if (life >= 1)
            {
                life -= 1;
                Destroy(hearts[life].gameObject);
                if (life < 1)
                {
                    dead = true;
                }

            }

        }
    }



}
