using UnityEngine;

public class RoombaMovement : MonoBehaviour
{
    [SerializeField] private float minXPos;
    [SerializeField] private float maxXPos;
    [SerializeField] private float minZPos;
    [SerializeField] private float maxZPos;
    [SerializeField] private float patrolSpeed;
    [SerializeField] private bool isMovingDown;
    [SerializeField] private bool isMovingUp;
    [SerializeField] private bool isMovingRight;
    [SerializeField] private bool isMovingLeft;
    private Vector3 moveDir;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (isMovingLeft)
        {
            // sets move direction to left
            moveDir.x = -patrolSpeed;
            moveDir.z = 0;

            // 
            if (transform.position.x <= minXPos)
                isMovingLeft = false;
                isMovingUp = true;
        }
        else if (isMovingUp)
        {
            // sets move direction to up
            moveDir.z = patrolSpeed;
            moveDir.x = 0;

            // 
            if (transform.position.z >= maxZPos)
                isMovingUp = false;
                isMovingRight = true;
                
        }
        else if (isMovingRight)
        {
            // sets move direction to right
            moveDir.x = patrolSpeed;
            moveDir.z = 0;

            // 
            if (transform.position.x >= maxXPos)
                isMovingRight = false;
                isMovingDown = true;
        }
        else if (isMovingDown)
        {
            // sets move direction to down
            moveDir.z = -patrolSpeed;
            moveDir.x = 0;

            // 
            if (transform.position.z <= minZPos)
                isMovingDown = false;
                isMovingLeft = true;
                
        }
        else
        {
            print("roomba movement script broke");
        }

        rb.position += moveDir * Time.deltaTime;
    }
}
