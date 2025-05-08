using UnityEngine;

// 두 회전 사이클을 부드럽게 보간하는 함수
// 보간 계수 t가 0~1 범위를 벗어나도 계산된다는 점에 다르다

//Vector3.SlerpUnclamped(Quaternion a, Quaternion b, float t);
// a : 시작 회전
// b : 끝 회전
// t : 보간 계수
// 0이면 a, 1이면 b
// 1보다 크거나 0보다 작을 수 있음

public class VectorSlerpUnclamped : MonoBehaviour
{
    public Transform start;
    public Transform end;

    public bool update = false;
    public float speed = 0.1f;
    public float elapsed = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            update = true;
            transform.position = start.position;
            elapsed = 0;
        }

        if (update)
        {
            elapsed += speed;

            transform.position = Vector3.SlerpUnclamped(transform.position, end.position, elapsed);

            if (transform.position == end.position) update = false;
        }
    }
}
