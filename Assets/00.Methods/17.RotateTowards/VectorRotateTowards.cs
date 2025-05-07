using UnityEngine;
// RotateTowards�Լ��� �Ű�����
// ù��° : ���� ����
// �ι�° : Ÿ�� ����
// ����° : ȸ���� ���Ǵ� ���ȴ����� �ִ� ���� : ������ ��ȭ��
// �׹�° : ȸ���� ���Ǵ� ������ �ִ� ���� : ũ���� ��ȭ��
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
