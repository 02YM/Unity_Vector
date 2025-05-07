using UnityEngine;

public class VectorMoveTowards : MonoBehaviour
{
    public float moveSpeed = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 forward = new Vector3(horizontal, 0, vertical);

        if(forward.magnitude >0)
        {
            Vector3 dir = transform.TransformDirection(forward);
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, moveSpeed * Time.deltaTime);
        }
    }
}
