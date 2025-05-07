using UnityEngine;

// Lerp�Լ��� ����Ͽ� ���� �������� Ŭ���� �������� �̵��ϴ� �����Դϴ�.
public class UseLerpToMoveWhenKeyIngin : MonoBehaviour
{
    public Vector3 Dir = Vector3.zero;
    public bool KeyPress = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        if(direction.magnitude > 0)
        {
            // ���� ��ǥ���� ���⺤�͸� ������ǥ��� ��ȯ�ϴ� ����Դϴ�.
            Dir = transform.position + transform.TransformDirection(direction);
            KeyPress = true;
        }
        else if(direction.magnitude == 0)
        {
            KeyPress = false;
        }

        if(KeyPress)
        {
            transform.position = Vector3.Lerp(transform.position, Dir, Time.deltaTime);
        }
    }
}
