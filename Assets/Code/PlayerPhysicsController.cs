using UnityEngine;

public class PlayerPhysicsController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed;
        float rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;

        rb.velocity = transform.forward * move;
        rb.angularVelocity = new Vector3(0, rotate, 0);
    }
}