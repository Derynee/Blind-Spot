using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelecObjeto : MonoBehaviour
{

    [SerializeField] AdminUI adminUI;
    

    public void Agarrar(int i)
    {
        Debug.Log("Agarrando");
        adminUI.ObjetosInventario[i].gameObject.SetActive(true);     
    }
}
