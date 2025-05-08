using UnityEngine;

public class VectorSlerp : MonoBehaviour
{
    public Transform start;
    public Transform end;

    public bool update = false;
    public float speed = 0.01f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            update = true;
            transform.position = start.position;
        }

        if(update)
        {
            transform.position = Vector3.Slerp(transform.position, end.position, speed);

            if (transform.position == end.position) update = false;
        }
    }
}
