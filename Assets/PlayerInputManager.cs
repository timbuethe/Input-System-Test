using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
   [UsedImplicitly]
   public void OnPlayerJoined(PlayerInput playerInput)
   {
      var player = playerInput.gameObject.GetComponent<Player>();
      player.SetPlayerInput(playerInput);
      Debug.Log($"playerInput: {playerInput}");
   }
}
