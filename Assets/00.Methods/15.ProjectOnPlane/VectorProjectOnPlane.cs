using UnityEngine;
// 벡터를 평면에 투영하는데 사용됩니다.
// 보통 물리학 계산, 충돌 처리, 카메라 시스템
// ProjectOnPlane(vector, planeNormal)
// vector : 평면에 투양할 벡터입니다.
// planeNormal : 투영하려는 평면의 법선 벡터입니다. 법선 벡터는 평면의 수직 방향입니다.
// 공식 = V - (V * N) * N

// 용도.
// 1. 충돌계산
// 2. 카메라 시스템
// 3. 조명 및 셰이더

public class VectorProjectOnPlane : MonoBehaviour
{

    public Vector3 vector = new Vector3(3, 4, 5);
    public Vector3 planeNormal = new Vector3(0, 1, 0);
    // 3, 0, 5 결과가 나옴니다.


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.ProjectOnPlane(vector, planeNormal));
    }
}
