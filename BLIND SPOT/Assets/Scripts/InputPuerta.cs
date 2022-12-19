using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputPuerta : MouseInput
{
    public WallMain ReferenciaWallMain;
    public int StateToGo;
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        ReferenciaWallMain.ManageState(StateToGo);
    }
}
