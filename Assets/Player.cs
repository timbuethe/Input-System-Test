using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [UsedImplicitly]
    public void Fire(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        Debug.Log($"Fire!");
    }
}