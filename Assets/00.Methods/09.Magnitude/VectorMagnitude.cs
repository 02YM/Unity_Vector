using UnityEngine;
// ������ �������� �Ѱ��ִ� �Լ��Դϴ�.
// ���Ϸ�
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
            // ������ ������ ������ �������ϰ�, ���� ���� ��ȯ�մϴ�.
            Debug.Log(Vector3.SqrMagnitude(transform.position));

        else
            // ������ ���̸� ��ȯ�մϴ�.
            Debug.Log(Vector3.Magnitude(transform.position));
    }
}
