/*
*Zackary Hopkins
*Assignment5B
*Takes mouse input and moves the camera
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotatie player on the horizontail axis
        player.transform.Rotate(Vector3.up * mouseX);

        //rotate the camera around the x axis with vertical mouse imput
        verticalLookRotation -= mouseY;

        //limit the vertical rotation
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        //apply rotation to our camera based on clamped output
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }
}
