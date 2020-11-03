using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
* This componenet oscillate the object in fixed speed
*/
public class Oscillator : MonoBehaviour
{
    [Tooltip("Movement speed in meters per second")]
    [SerializeField] 
    float speed = 1f;
    [SerializeField]
    int direction = 1;
    [SerializeField]
    int movement_scale = 9;
    //float movement_speed = 1f;


    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //movement_speed=speed;
    }

    // Update is called once per frame
    void Update()
    {  
        float dis = oscillate(timer, speed, movement_scale); // computing the fixed distance movement. (by Sin function)
        transform.position = new Vector3(direction*dis, transform.position.y , transform.position.z); // setting the new x's coordinate to the object.
        //speed = (Mathf.PI/timer)*Mathf.Asin(dis/movement_scale);
        timer += Time.deltaTime; // computing the whole time of the movement so far per frame.
    }

    /**
     * side function that computing the object's distance by Sin function
     */
    float oscillate(float time, float speed, float scale)
    {
        return Mathf.Sin(time * speed/Mathf.PI) * scale;
    }
}
