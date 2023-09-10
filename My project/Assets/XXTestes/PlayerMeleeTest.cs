using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMeleeTest : MonoBehaviour
{

    private CharControls input;
    private void Awake()
    {
        input = new CharControls();
    }
    private void OnEnable()
    {
        input.Enable();
        input.Player.Melee.performed += DaUmTapao;

    }
    private void OnDisable()
    {
        input.Disable();
        input.Player.Melee.performed -= DaUmTapao;
    }

    private void DaUmTapao(InputAction.CallbackContext ctx)
    {
        Debug.Log("Tapão memo");
    }

}
