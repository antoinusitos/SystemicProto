using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugAction : MonoBehaviour
{
    public string toDebug = "";

    public void Execute()
    {
        Debug.Log(toDebug);
    }

}
