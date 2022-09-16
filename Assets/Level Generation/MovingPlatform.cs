using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public List<Transform> waypoint;
    public float moveSpeed;
    public int target;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoint[target].position, moveSpeed * Time.deltaTime);
        
    }
    private void FixedUpdate()
    {
        if(transform.position == waypoint[target].position)
        {
            if(target == waypoint.Count - 1)
            {
                target = 0;

            }
            else
            {
                target += 1;
            }

        }
        
    }
}
