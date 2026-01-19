using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovrTank : MonoBehaviour
{
    public int speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CarMove();
    }

    void CarMove()
    {

        /*if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            Vector2 a = transform.right;
            transform.position = a;
        }*/
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Debug.Log("11111");
            Vector2 a = transform.right;

            transform.position = a;
        }
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            Vector2 a = transform.right * -1;
            transform.position = a;
        }
   
    }
}
