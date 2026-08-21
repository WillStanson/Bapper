using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float Speed = 12f;
    [SerializeField] private float turnRadius = 180f; //Not planning to have this.
    [SerializeField] private KeyCode rotateLeftButton;
    [SerializeField] private KeyCode rotateRightButton;
    [SerializeField] private KeyCode forwardsButton;
    [SerializeField] private KeyCode backwardsButton;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(rotateLeftButton))
            rotateSofa(-1);
        if (Input.GetKey(rotateRightButton))
            rotateSofa(1);
        if (Input.GetKey(forwardsButton))
            rb.AddForce(transform.forward * Speed * Time.deltaTime);
        if (Input.GetKey(backwardsButton))
            rb.AddForce(transform.forward * -Speed * Time.deltaTime);

    }

    void rotateSofa(int rotateDirection)
    {
        float rotateAmount = turnRadius * rotateDirection * Time.deltaTime;

        transform.Rotate(Vector3.up, rotateAmount);
    }

    void sofaMovement(int movementDirection)
    {
        float movementAmount = Speed * movementDirection * Time.deltaTime;

        rb.linearVelocity = transform.forward * Speed * movementDirection;

    }
}
