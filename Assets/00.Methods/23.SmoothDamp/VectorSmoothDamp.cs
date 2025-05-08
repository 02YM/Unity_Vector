using UnityEngine;

/*
 smoothDamp함수는 시간이 지남에 따라 원하는 지점으로 부드럽게 점진적으로 변경하는 
함수입니다. 계산된 값은 절대 오버슈트( 값이 한 번에 크게 변동되는 일 ) 없이 
스프링 댐퍼와 같은 기능으로 매끄럽게 이동처리됩니다. 가장 일반적인 용도로는
타겟을 따라가는 카메라를 구현할 때 매끄럽게 이동되도록 사용되어 집니다.
 */

// current : 현재 위치
// target : 타겟 위치
// currentVelocity : 이전 호출시점에서 현재 호출시점까지의 속력 ( 현재속력 )
// smoothTime : 목표에 도달하는데 걸리는 대략적인 시간, 값이 작을 수록 더 빨리 도달
// maxSpeed : 최대 속도
// deltaTime : 마지막 호출 이후의 시간 기본값은 Time.deltaTime입니다.

public class VectorSmoothDamp : MonoBehaviour
{
    public Transform target;
    public Vector3 currentVelocty;
    public float smoothTime = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            Vector3.SmoothDamp(transform.position, target.position, ref currentVelocty, smoothTime);
    }
}
