using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    public Transform target;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    void LateUpdate()
    {
        if (target != null)
        {
            float clampedX = Mathf.Clamp(target.position.x, minPosition.x, maxPosition.x);
            float clampedY = Mathf.Clamp(target.position.y, minPosition.y, maxPosition.y);

            transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    }
}
