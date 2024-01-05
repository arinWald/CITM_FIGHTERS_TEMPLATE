using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSelector : MonoBehaviour
{
    [SerializeField] private GameObject newPlayerPrefab; // The new Player Prefab to use.

    public PlayerInputManager inputManager;

    private void Update()
    {
        if (GameObject.FindWithTag("Azri")) //Checking for a game object with the tag
        {
            PlayerInputManager.instance.playerPrefab = newPlayerPrefab; //If yes, changes the player prefab field to your selected prefab
        }
    }
}