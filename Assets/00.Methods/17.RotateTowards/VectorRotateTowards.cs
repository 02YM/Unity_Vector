using UnityEngine;
// RotateTowards함수의 매개변수
// 첫번째 : 시작 벡터
// 두번째 : 타겟 벡터
// 세번째 : 회전에 허용되는 라디안단위의 최대 각도 : 각도의 변화량
// 네번째 : 회전에 허용되는 벡터의 최대 길이 : 크기의 변화량
public class VectorRotateTowards : MonoBehaviour
{
    public Transform target;

    public float MoveSpeed = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, dir, MoveSpeed * Time.deltaTime, 0);

        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
