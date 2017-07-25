using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAB : MonoBehaviour
{
    //object to move
    public GameObject spider;
    //starting pos
    private Vector3 startPos;
    // ending pos
    private Vector3 endPos;
    //distance to do
    private float distance = 3f;
    // time to make it in secs
    private float lerpTime = 3;
    //updating lerptime
    public float currentLerpTime = 0;

    private bool keyHit = false;

    void Start()
    {
        startPos = spider.transform.position;
        endPos = spider.transform.position + Vector3.right*distance;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            keyHit = true;
        }
        if (keyHit == true)
        {
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }
            float Perc = currentLerpTime / lerpTime;
            spider.transform.position = Vector3.Lerp(startPos, endPos, Perc);
        }
    }

}
