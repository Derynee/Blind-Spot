using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechaUno : MonoBehaviour
{
    bool ButtonSpacePressed;
    // Start is called before the first frame update
    void Start()
    {
        ButtonSpacePressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)) 
        {
            Debug.Log("Button was pressed succesfully");
            ButtonSpacePressed = true;
        }
        ButtonSpacePressed = false;
    }
}
