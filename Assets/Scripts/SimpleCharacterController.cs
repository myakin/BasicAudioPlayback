using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public Transform cam;
    public float moveSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.position += transform.forward * (ver * moveSpeed * Time.deltaTime) + transform.right * (hor * moveSpeed * Time.deltaTime);
        transform.rotation *= Quaternion.Euler(0, mouseX, 0);
        cam.rotation *= Quaternion.Euler(mouseY, 0 ,0); 

    }
}
