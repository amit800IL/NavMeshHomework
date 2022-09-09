using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] Transform Target;
    [SerializeField] Transform Obstacle;
    private Vector3 obstacleStartingPosition;
    bool isMovingToTarget;
    [SerializeField] float movementSpeed;

    private void Start()
    {
        obstacleStartingPosition = Obstacle.position;
        isMovingToTarget = true;
    }

    private void Update()
    {
        if (isMovingToTarget)
        {
           Obstacle.position = Vector3.MoveTowards(Obstacle.position, Target.position, movementSpeed * Time.deltaTime);
            if (Vector3.Distance(Obstacle.position, Target.position) < 1f)
            {
                isMovingToTarget = false;
            }
        }

        else
        {
            Obstacle.position = Vector3.MoveTowards(Obstacle.position, obstacleStartingPosition, movementSpeed * Time.deltaTime);
            if (Vector3.Distance(Obstacle.position, obstacleStartingPosition) < 1f)
            {
                isMovingToTarget = true;
            }
        }
    }
}

