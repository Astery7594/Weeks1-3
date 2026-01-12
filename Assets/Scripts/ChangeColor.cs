using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TextCore.Text;

public class ChangeColor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    /*public Sprite barrel0;
    public Sprite barrel1;
    public Sprite barrel2;*/

    public List <Sprite> barrel;

    public int rN;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("111");
            //PickARandomColor();
            PickARandomSprite();
        }

        Vector2 mouseP = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mouseP))
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color=Color.white;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame==true&& barrel.Count>1)
        {
            barrel.RemoveAt(0);
        }

    }

    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        rN = Random.Range(0, barrel.Count);

        spriteRenderer.sprite = barrel[rN];

        /*if (rN == 0)
        {
            spriteRenderer.sprite = barrel0;
        }
        else if (rN == 1)
        {
            spriteRenderer.sprite = barrel1;
        }
        else
        {
            spriteRenderer.sprite = barrel2;
        }*/


    }
}
