using UnityEngine;

// Scale �Լ��� ������ ���� �Ű������� ���� �������� �Լ��Դϴ�.

public class VectorScale : MonoBehaviour
{
    public Vector3 scale = new Vector3(10, 10, 10);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {

            scale.Scale(new Vector3(20, 1, 20));
            // (20 * 10, 1 * 10, 20 * 10)

            transform.localScale = scale;
        }
    }
}
