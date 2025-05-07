using UnityEngine;

// Vector3.OrthoNormalize함수는 (normal, tangent, binormal)
// Normal 벡터를 받고, Tangent 벡터를 매개변수로 받으며
// Tangent 벡터를 Normal 벡터에 수직인 벡터로 변경합니다.
// 그리고 Normal, Tangent 벡터 모두 길이가 1인 단위벡터로 변경합니다.


// 1. normal을 정규화
// 2. trangent를 normal에 수직이 되도록 보정한 후 정규화
// 3. binormal을 normal * tanget로 계산(직교, 정규화된 벡터)

// !! 조건
// 모두 길이가1
// 서로 직교
// binormal = Vector3.Cross(normal, tangent)

public class VectorOrthoNormalize : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1번 예제(수직인 벡터를 넣어봄 ) : 그대로 수직인 벡터로 출력됨.
        //Vector3 up = new Vector3(0, 1, 0);
        //Vector3 right = new Vector3(1, 0, 0);
        //Vector3.OrthoNormalize(ref up, ref right);
        //print(up);
        //print(right);

        // 2번 예제 ( 45도 각도가 되도록 설정함 ) : 수직이게 처리됨
        //Vector3 up = new Vector3(10, 10, 0) * 10;
        //Vector3 right = new Vector3(10, 0, 0);
        //Vector3.OrthoNormalize(ref up, ref right);
        //print(up);
        //print(right);

        // 3번 예제 ( 평행하게 처리하고, 결과를 살펴봄 ) : 수직이게 처리됨.
        Vector3 up = new Vector3(1, 1, 0);
        Vector3 right = new Vector3(-1, -1, 0);
        Vector3.OrthoNormalize(ref up, ref right);
        print(up);
        print(right);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
