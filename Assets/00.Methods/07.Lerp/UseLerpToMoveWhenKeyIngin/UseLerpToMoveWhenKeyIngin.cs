using UnityEngine;

// Lerp함수를 사용하여 현재 시점에서 클릭한 시점으로 이동하는 예제입니다.
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
            // 로컬 좌표계의 방향벡터를 월드좌표계로 변환하는 기능입니다.
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
