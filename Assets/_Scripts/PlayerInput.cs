using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerController _controller;
    private MovementController _moveController;
    public Transform playerTransform;

    private float _upDown;
    private float _speed;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _moveController = GetComponent<MovementController>();
    }

    private void Update()
    {
        // Move horizontally with the _speed variable
        float horizontalMovement = _speed * Time.deltaTime * 3;

        //if(GameObject.FindGameObjectWithTag("Azri") == this.gameObject)
        //{
        //    horizontalMovement = -horizontalMovement;
        //}

        Vector3 horizontalVelocity = new Vector3(horizontalMovement, 0f, 0f);
        playerTransform.Translate(horizontalVelocity);

        // Call TryMove method for other movements
        _moveController.TryMove(_speed);
    }
    // Start is called before the first frame update
    private void OnMove(InputValue input)
    {
        _speed = input.Get<float>();

    }

    private void OnUpDown(InputValue input)
    {
        _upDown = input.Get<float>();        
    }

    private void OnQuickAttack()
    {
        if (_upDown >= 0)
            _controller.TryHighQuickAttack();
        else
            _controller.TryLowQuickAttack();
    }
    private void OnSlowAttack()
    {
        if (_upDown >= 0)
            _controller.TryHighSlowAttack();
        else
            _controller.TryLowSlowAttack();
    }

    private void OnBlock()
    {
        if (_upDown >= 0)
            _controller.TryHighBlock();
        else
            _controller.TryLowBlock();
    }
}
