using UnityEngine;

// tangent : 접선 ( tangent line은 곡선 (또는 도형) 위의 한 점에서 곡선에 접하는 직선)을

public class VectorOrthoNormalize3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1번 예제 ( 수직인 벡터를 넣어봄 ) : 그대로 수직인 벡터로 출력됨.
        //Vector3 normal = new Vector3(0, 1, 0);
        //Vector3 tangent = new Vector3(1, 0, 0);
        //Vector3 binormal = new Vector3(0, 0, 1);
        //Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
        //print(normal);
        //print(tangent);
        //print(binormal);

        // 
        // 2번 예제 (x좌표만 반대로 함. ) : binormal만 1번 예제와 반대로 출력됨
        //Vector3 normal = new Vector3(0, 1, 0);
        //Vector3 tangent = new Vector3(-1, 0, 0);
        //Vector3 binormal = new Vector3(0, 0, 0);
        //Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
        //print(normal);
        //print(tangent);
        //print(binormal);

        // 3번 예제 ( tangent를 입력하지 않았을때 normal과 binormal을 시계방향으로 수직으로 한 벡터(-1, 0, 0 )가 출력됨 )                   
        //Vector3 normal = new Vector3(0, 1, 0);
        //Vector3 tangent = new Vector3(0, 0, 0);
        //Vector3 binormal = new Vector3(0, 0, -1);
        //Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
        //print(normal);
        //print(tangent);
        //print(binormal);

        // 4번 예제 ( normal 벡터만 제공했을때 ) (0,1,0), (-1, 0,0), (0,0,1) 벡터
        // 수직인 벡터가 출력됨.
        Vector3 normal = new Vector3(0, 1, 0);
        Vector3 tangent = new Vector3(0, 0, 0);
        Vector3 binormal = new Vector3(0, 0, 0);
        Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
        print(normal);
        print(tangent);
        print(binormal);
    }
}
