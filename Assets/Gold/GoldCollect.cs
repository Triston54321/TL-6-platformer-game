using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCollect : MonoBehaviour
{

    public Text GoldCounter;
    private int GoldAmount;
    // Start is called before the first frame update
    void Start()
    {
        GoldAmount = 0;
        GoldCounter.text = "Gold: " + GoldAmount;
        
    }

    private void OnTriggerEnter2D(Collider2D myGold)
    {
        if(myGold.tag == "myGold")
        {
            GoldAmount += 1;
            Destroy(myGold.gameObject);
            GoldCounter.text = "Gold: " + GoldAmount;

        }
    }

    
}