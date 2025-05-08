using UnityEngine;

public class VectorSqrMagnitude : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 벡터의 길이를 넘겨주는 함수입니다. (제곱근의 길이가 아닌 각 요소의 제곱의 대한 합)
        print(Vector3.SqrMagnitude(transform.position));
    }
}
