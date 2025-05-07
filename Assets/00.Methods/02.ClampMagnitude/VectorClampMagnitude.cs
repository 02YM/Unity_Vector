using UnityEngine;

//ClampMagnitude함수는 두번째 매개변수로 넘겨받은 길이값 제곱보다
// 현재 벡터의 길이가 더 크다면 벡터의 길이값의 제곱근을 구하고
// 벡터의 각 요소를 제곱근으로 나눈후 다시 두번째 매개변수로 넘겨받은 길이값을 
// 곱해 벡터의 각 요소의 최대길이를 매개변수로 넘겨받은 길이값으로 맞춰주는 함수입니다.
// Cube의 스케일은 (5, 1, 1)입니다.ClampMagnitude를 사용하여
// 스케일의 비율을 유지하며 작게 만드는 예제를 준비해 보았습니다.

public class VectorClampMagnitude : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            transform.localScale = Vector3.ClampMagnitude(transform.localScale, 1);
        }
    }
}
