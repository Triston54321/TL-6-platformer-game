using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            //Time.timeScale = 0f;
            SceneManager.LoadScene("GameOver");

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
