using UnityEngine;

// Cross는 벡터 외적 함수입니다.
// 두 벡터에 수직인 벡터를 넘겨주는 함수이며
// 계산식은 다음과 같습니다.
// Vector3(lhs.y * rhs.z - lhs.z * rhs.y,
//         lhs.z * rhs.x - lhs.x * rhs.z,
//         lhs.x * rhs.y - lhs.y * rhs.x)

public class Vector3Cross : MonoBehaviour
{

    public Transform up;
    public Transform right;
    public Transform result;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            result.position = Vector3.Cross(up.position, right.position);
    }
}
