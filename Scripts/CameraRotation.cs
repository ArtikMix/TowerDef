using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Transform target;

    private Vector3 offset;
    private float zoomSpeed = 4f;
    private float minZoom = 5f;
    private float maxZoom = 15f;
    private float pitch = 2f;
    private float currentZoom = 10f;
    private float yawSpeed = 100f;
    private float yawInput = 0f;


    private void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        yawInput = Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        transform.RotateAround(target.position, Vector3.up, yawInput);
    }
}
