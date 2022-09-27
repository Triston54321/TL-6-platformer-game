using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoldCollect : MonoBehaviour

{
    public AudioSource source;
    public Text GoldCounter;
    private int GoldAmount;



    // Start is called before the first frame update
    void Start()
    {
        GoldAmount = 0;
        GoldCounter.text = "Gold: " + GoldAmount;
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (GoldAmount == 10)
        {
            SceneManager.LoadScene("GameOver");

        }
    }


    private void OnTriggerEnter2D(Collider2D myGold)
    {
        if(myGold.tag == "myGold")
        {
            GoldAmount += 1;
            Destroy(myGold.gameObject);

            source.Play();

            GoldCounter.text = "Gold: " + GoldAmount;
         
        }
    }

    
}
