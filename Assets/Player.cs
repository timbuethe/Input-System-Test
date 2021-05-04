using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerInput _playerInput;

    [UsedImplicitly]
    public void Fire(InputAction.CallbackContext context)
    {
        if (!_playerInput) return;
        if (!context.started) return;
        Debug.Log($"Fire! (playerIndex: {_playerInput.playerIndex})");
    }

    public void SetPlayerInput(PlayerInput playerInput)
    {
        _playerInput = playerInput;
    }
}