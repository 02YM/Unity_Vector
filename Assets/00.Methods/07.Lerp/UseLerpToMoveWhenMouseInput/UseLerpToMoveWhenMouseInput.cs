using UnityEngine;

public class UseLerpToMoveWhenMouseInput : MonoBehaviour
{
    public LayerMask groundLayer;
    public Vector3 targetPosition;
    public float moveSpeed = 1;
    public bool useLerp = false;
    public Vector3 refVelocity;
    public float smoothTime = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 좌표르ㄹ 기준으로 레이를 생성합니다.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawLine(ray.origin, ray.direction * 1000);

        if(Physics.Raycast(ray, out RaycastHit hit, 1000, groundLayer))
        {
            targetPosition = hit.point;
        }

        if(useLerp)
        {
            transform.position = Vector3.Lerp(transform.position,
                                              targetPosition,
                                              Time.deltaTime * moveSpeed);
        }
        else
        {
            transform.position = Vector3.SmoothDamp(transform.position,
                                                    targetPosition,
                                                    ref refVelocity,
                                                    smoothTime);
        }
    }
}
