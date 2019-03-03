using UnityEngine;

public class StayInside : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f),
        Mathf.Clamp(transform.position.y, -4f, 3f), transform.position.z);
    }
}