using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    public Transform TargetTransform; // 따라갈 대상
    public Vector2 targetPosition; // 목표 위치
    private Vector2 refVelocity; // SmoothDamp 참조 속도

    public float smoothSpeed = 1.0f; // 부드러운 이동 속도
    public float gizmoSize = 2f; // 기즈모 크기

    void FixedUpdate()
    {
        if (TargetTransform != null)
        {
            // TargetTransform의 위치를 목표 위치로 부드럽게 이동
            Vector2 currentPosition = TargetTransform.position;
            TargetTransform.position = Vector2.SmoothDamp(
                currentPosition,
                targetPosition,
                ref refVelocity,
                smoothSpeed
            );
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, Vector3.one * gizmoSize);
    }
}
