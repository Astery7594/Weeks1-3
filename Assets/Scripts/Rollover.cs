using UnityEngine;
using UnityEngine.InputSystem;

public class Rotate : MonoBehaviour
{
    public bool mouseIsOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseP = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float dis = Vector2.Distance(mouseP, transform.position);
        if (dis < 1)
        {
            mouseIsOver = true;
        }
        else
        {
            mouseIsOver = false;
        }
    }
}