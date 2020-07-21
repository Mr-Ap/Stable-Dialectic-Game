using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdperson : MonoBehaviour
{
    public Transform playercam, character, centrepoint;

    private float mouseX, mouseY;
    public float mouseSensitivity = 10f;
    public float mouseYposition = 1f;

    private float moveFB, moveLR;
    public float movespeed = 2f;

    public float zoom;
    public float zoomSpeed = 2f;

    public float zooMin = -2f;
    public float zooMax = -10f;

    public float rotationSpeed = 5f;
    //private float speedmouse = 2.0f;
    // Use this for initialization
    void Start()
    {
        zoom = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        
        zoom += Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        if (zoom > zooMin)
            zoom = zooMin;

        if (zoom < zooMax)
            zoom = zooMax;

        playercam.transform.localPosition = new Vector3(0, 3f, zoom);

        if (Input.GetMouseButton(1))
        {
            mouseX += Input.GetAxis("Mouse X");
            mouseY -= Input.GetAxis("Mouse Y");
        }
        //mouseY = Mathf.Clamp(mouseY, -60f, -60f);
        playercam.LookAt(centrepoint);
        centrepoint.localRotation = Quaternion.Euler(mouseY, mouseX, 0);

        moveFB = Input.GetAxis("Vertical") * movespeed;
        moveLR = Input.GetAxis("Horizontal") * movespeed;
        Vector3 movement = new Vector3(moveLR, 0, moveFB);
        movement = character.rotation * movement;
        character.GetComponent<CharacterController>().Move(movement * Time.deltaTime);
        centrepoint.position = new Vector3(character.position.x, character.position.y + mouseYposition, character.position.z);

        if (Input.GetAxis("Vertical") < 0 || Input.GetAxis("Vertical") > 0)
        {
            Quaternion turnAngle = Quaternion.Euler(0, centrepoint.eulerAngles.y, 0);
            character.rotation = Quaternion.Slerp(character.rotation, turnAngle, Time.deltaTime * rotationSpeed);
        }
    }
}
