using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private Transform rotateAround;

    private bool isClockwise = true;

    // Update is called once per frame
    void Update()
    {
        
        float direction = isClockwise ? 1 : -1; //direction of the rotation

        
        this.transform.RotateAround(rotateAround.position, Vector3.forward, direction * rotationSpeed * Time.deltaTime); // rotation of specific core

        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            ToggleRotationDirection();
        }
    }

    // Toggle the rotation direction
    private void ToggleRotationDirection()
    {
        isClockwise = !isClockwise; // Switch the direction
    }
}
