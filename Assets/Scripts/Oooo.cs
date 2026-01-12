using UnityEngine;

public class Oooo : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 r = transform.eulerAngles;
        r.z += speed * Time.deltaTime;
        transform.eulerAngles = r;
    }
}
