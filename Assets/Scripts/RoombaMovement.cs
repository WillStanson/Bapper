using UnityEngine;

public class RoombaMovement : MonoBehaviour
{

    [SerializeField] private float minXPos;
    [SerializeField] private float maxXPos;
    [SerializeField] private float minYPos;
    [SerializeField] private float maxYPos;
    [SerializeField] private float patrolSpeed;
    [SerializeField] private bool isMovingDown;
    [SerializeField] private bool isMovingUp;
    [SerializeField] private bool isMovingRight;
    [SerializeField] private bool isMovingLeft;
    private Vector2 moveDir;

    void Update()
    {
        if (isMovingLeft)
        {
            // sets move direction to left
            moveDir.x = -patrolSpeed;

            // switches to right if it moves to/past the defined minimum x position
            if (transform.position.x <= minXPos)
                moveDir.x = 0;
                isMovingLeft = false;
                isMovingUp = true;
        }
        else if (isMovingUp)
        {
            // sets move direction to up
            moveDir.y = patrolSpeed;

            // switches to left if it moves to/past the defined maximum x position
            if (transform.position.x >= maxXPos)
                moveDir.y = 0;
                isMovingRight = true;
                isMovingUp = false;
        }
        else if (isMovingRight)
        {
            // sets move direction to right
            moveDir.x = patrolSpeed;

            // switches to right if it moves to/past the defined minimum x position
            if (transform.position.x <= minXPos)
                moveDir.x = 0;
                isMovingLeft = false;
                isMovingDown = true;
        }
        else if (isMovingDown)
        {
            // sets move direction to down
            moveDir.y = -patrolSpeed;

            // switches to left if it moves to/past the defined maximum x position
            if (transform.position.x >= maxXPos)
                moveDir.y = 0;
                isMovingLeft = true;
                isMovingDown = false;
        }
        else
        {
            print("roomba movement script broke");
        }
    }
}
