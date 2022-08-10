using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefaultCursor : MonoBehaviour
{
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    void Start()
    {
        Cursor.SetCursor(null, hotSpot, cursorMode);
    }

    
}
