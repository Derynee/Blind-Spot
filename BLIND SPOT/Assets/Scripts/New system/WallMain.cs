using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WallMain : MonoBehaviour
{
    [SerializeField] SpriteRenderer imageComponent;
    [SerializeField] State startingState;

     State state;
    

    // Start is called before the first frame update
    void Start()
    {

        state = startingState;
        imageComponent.sprite = state.GetStateRoom();
        
    }

    // Update is called once per frame
    void Update()
    {
       // ManageState();
    }

    public void ManageState(int i)
    {
        var nextStates = state.GetNextStates();
        state = nextStates[i];

        /*
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            //Input.GetKeyDown(KeyCode.Space)
            state = nextStates[2];
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            state = nextStates[3];
        }
        else if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            state = nextStates[4];
        } */
        imageComponent.sprite = state.GetStateRoom();
        
    }

}
