using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
* This component allow to change the visiblty of the object
*/
public class VisibiltyByClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            // changing the visiblity of the object each click
            GetComponent<Renderer>().enabled = !(GetComponent<Renderer>().enabled);
        }        
    }
}
