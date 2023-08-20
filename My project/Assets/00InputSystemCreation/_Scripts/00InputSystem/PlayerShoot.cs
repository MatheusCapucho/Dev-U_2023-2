using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    private PlayerControls inputs;

    private void Awake()
    {
        inputs = new PlayerControls();
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Shoot.performed += Shoot;
    }
    private void OnDisable()
    {
        inputs.Disable();
        inputs.Player.Shoot.performed -= Shoot;
    }
    private void Shoot(InputAction.CallbackContext ctx)
    {
        Instantiate(bulletPrefab, transform.position + Vector3.forward, Quaternion.identity);
    }

}
