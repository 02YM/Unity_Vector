using UnityEngine;

public class VectorDistance : MonoBehaviour
{
    public Transform Player;
    public Transform Enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(Player.position, Enemy.position));
    }
}
