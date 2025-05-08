using UnityEngine;

/*
 smoothDamp�Լ��� �ð��� ������ ���� ���ϴ� �������� �ε巴�� ���������� �����ϴ� 
�Լ��Դϴ�. ���� ���� ���� ������Ʈ( ���� �� ���� ũ�� �����Ǵ� �� ) ���� 
������ ���ۿ� ���� ������� �Ų����� �̵�ó���˴ϴ�. ���� �Ϲ����� �뵵�δ�
Ÿ���� ���󰡴� ī�޶� ������ �� �Ų����� �̵��ǵ��� ���Ǿ� ���ϴ�.
 */

// current : ���� ��ġ
// target : Ÿ�� ��ġ
// currentVelocity : ���� ȣ��������� ���� ȣ����������� �ӷ� ( ����ӷ� )
// smoothTime : ��ǥ�� �����ϴµ� �ɸ��� �뷫���� �ð�, ���� ���� ���� �� ���� ����
// maxSpeed : �ִ� �ӵ�
// deltaTime : ������ ȣ�� ������ �ð� �⺻���� Time.deltaTime�Դϴ�.

public class VectorSmoothDamp : MonoBehaviour
{
    public Transform target;
    public Vector3 currentVelocty;
    public float smoothTime = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            Vector3.SmoothDamp(transform.position, target.position, ref currentVelocty, smoothTime);
    }
}
