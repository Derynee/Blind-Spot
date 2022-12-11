using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] Sprite storyImage;
    [SerializeField] State[] nextStates;

    public Sprite GetStateRoom()
    {
        return storyImage;
    }


    public State[] GetNextStates()
    {
        return nextStates;
    }
}
