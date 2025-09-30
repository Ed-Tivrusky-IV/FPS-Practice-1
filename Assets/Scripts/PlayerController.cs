using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float rotationSpeed = 100.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    void MoveThePlayer()
    {
        // We get the user's input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // We move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // We rotate the player
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);
    }
}
