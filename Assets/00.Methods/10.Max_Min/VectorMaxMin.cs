using UnityEngine;

public class VectorMaxMin : MonoBehaviour
{
    public Transform obj1;
    public Transform obj2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Max"+Vector3.Max(obj1.position, obj2.position));
        Debug.Log("Min" + Vector3.Min(obj1.position, obj2.position));
    }
}
