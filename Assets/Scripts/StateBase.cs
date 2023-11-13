using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new state", menuName ="State/BaseState")]
public abstract class StateBase : ScriptableObject
{
    public abstract void OnStart();
    public abstract void OnUpdate();

    public abstract void OnExit();
       
    
}
