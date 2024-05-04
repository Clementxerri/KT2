using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Le transform du personnage que la cam�ra doit suivre
    public Vector3 offset; // L'offset entre la cam�ra et le personnage
    public float smoothSpeed = 0.125f; // La vitesse de transition de la cam�ra
    public float delayTime = 0.5f; // Le d�lai avant que la cam�ra commence � bouger

    private float startTime;

    void Start()
    {
        startTime = Time.time; // Enregistre le moment o� le script est d�marr�
    }

    void LateUpdate()
    {
        if (target != null && Time.time - startTime > delayTime)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            transform.LookAt(target); // La cam�ra regarde toujours le personnage
        }
    }
}
