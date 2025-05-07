using UnityEngine;
// 벡터의 제곱근을 넘겨주는 함수입니다.
// 동일로
// Mathf.Sqrt()
// transform.position.magnitude
public class VectorMagnitude : MonoBehaviour
{

    public bool Sqr = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {                
        if(Sqr)
            // 벡터의 벡터의 길이의 제곱을하고, 던한 값을 반환합니다.
            Debug.Log(Vector3.SqrMagnitude(transform.position));

        else
            // 벡터의 길이를 반환합니다.
            Debug.Log(Vector3.Magnitude(transform.position));
    }
}
