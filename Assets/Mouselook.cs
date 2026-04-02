using UnityEngine;

public class Mouselook : MonoBehaviour
{
    public float mouseSensetivity = 100f;
    public Transform playerBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
