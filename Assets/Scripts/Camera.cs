using UnityEngine;

public class Camera : MonoBehaviour
{
    [Header("Objeto a ser seguido")]
    public Transform target;

    [Header("Configurações de Offset")]
    public Vector3 offset=new Vector3(0f, 5f, -10f);

    [Header("Suavização")]
    [Range(0.01f, 1f)]
    public float smoothTime=0.3f;

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position+offset;

        Vector3 smoothedPosition = Vector3.SmoothDamp(
            transform.position,
            desiredPosition,
            ref velocity,
            smoothTime
        );

        transform.position=smoothedPosition;
    }
}