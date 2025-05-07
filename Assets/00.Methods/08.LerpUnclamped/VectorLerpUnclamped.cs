using UnityEngine;

// Vector3.LerpUnclamped(Vector3 a, Vector3 b, float t)
// a : 시작 벡터
// b : 끝 벡터
// t : 보간 인자 (0 -> a, 1 -> b, 0.5 -> 중간, 초과/미만 가능)


public class VectorLerpUnclamped : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float t = 1.5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // t가 1.5면 pointB를 넘어서 이동합니다.
        Vector3 pos = Vector3.LerpUnclamped(pointA.position, pointB.position, t);
        transform.position = pos;
    }
}
