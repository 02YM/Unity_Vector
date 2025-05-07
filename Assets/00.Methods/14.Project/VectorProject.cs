using UnityEngine;

// 투영 벡터란
// 벡터 A를 벡터B의 방향으로 압축 시킨 벡터입니다.
// A의 방향성은 그대로 유지되지만, B의 방향을 따라 투영된 벡터입니다.
// 1번 내적 계산
// A와 B의 내적을 구합니다. (3 * 1) + (4 * 0) = 3

// 2번 자기 내적 계산
// B의 자기 내적을 구합니다. (1 * 1) + (0 * 0) = 1

// 3번 투영 계산
// 1번/2번 * B = 3,0

// 위를 정리한 투영 벡터 공식
// { (A * B) / (B * B) } * B = 

public class VectorProject : MonoBehaviour
{

    // A : 투영할 벡터
    // B : 투영하려는 기준 벡터
    public Vector3 A = new Vector3(3, 4, 0);
    public Vector3 B = new Vector3(1, 0, 0);

    void Start()
    {
        
    }

    
    void Update()
    {
        // A를 B에 투영
        Debug.Log(Vector3.Project(A, B));
    }
}
