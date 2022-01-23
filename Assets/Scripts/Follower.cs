using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public float speed = 5;
    public PathCreator pathCreator;
    float distanceTravelled;

    private void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }

}
