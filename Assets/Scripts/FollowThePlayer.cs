using UnityEngine;

public class FollowThePlayer : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 offset = new Vector3(0, 2, -4);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTransform.position + playerTransform.rotation * offset;
        transform.LookAt(playerTransform);

    }
}
