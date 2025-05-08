using UnityEngine;

// �� ȸ�� ����Ŭ�� �ε巴�� �����ϴ� �Լ�
// ���� ��� t�� 0~1 ������ ����� ���ȴٴ� ���� �ٸ���

//Vector3.SlerpUnclamped(Quaternion a, Quaternion b, float t);
// a : ���� ȸ��
// b : �� ȸ��
// t : ���� ���
// 0�̸� a, 1�̸� b
// 1���� ũ�ų� 0���� ���� �� ����

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
