using UnityEngine;

public class SmoothTarget : MonoBehaviour
{
    public Vector3 current;
    public float sinSpeed = 10f;
    public float graphValue = 0;
    public float radius = 1f;
    public float elapsed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current.x = Mathf.Sin(Time.time * sinSpeed) * radius;
        transform.position = current;
    }
}
