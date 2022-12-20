using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUIColliders : MonoBehaviour
{
    [SerializeField] string Habitacion;
    [SerializeField] int Vista;
    State state;
    


    // Start is called before the first frame update
    void Start()
    {
        //Habitacion = "Sotano";
    }



    // Update is called once per frame
    void Update()
    {
        // Habitacion = state.GetHabitacion();
        //if(Habitacion == "Sotano" && Vista == 1)
        //{
            
        //}
        
        if(Habitacion == state.GetHabitacion() && Vista == state.GetVista())
        {
            this.gameObject.SetActive(true);
            

        }
        
        

    }
}
