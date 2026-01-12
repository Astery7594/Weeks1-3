using UnityEngine;

public class Teleport : MonoBehaviour
{
    //public float s =0.00f;

    public float t = 0f;
    float x = 0f;
    float y = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // s = Random.Range(0.01f, 0.3f);
        //transform.position = (Vector2)transform.position +  Random.insideUnitCircle * 2;
        /*x = Random.Range(0, Screen.width);
        y = Random.Range(0, Screen.height);*/

        /*Vector2 pos = new Vector2(x, y);
        pos = Camera.main.ScreenToWorldPoint(pos);*/
        

    }

    // Update is called once per frame
    void Update()
    {
        t+=Time.deltaTime;
        x = Random.Range(0, Screen.width);
        y = Random.Range(0, Screen.height);
        
        Vector2 pos = new Vector2(x, y);
        pos = Camera.main.ScreenToWorldPoint(pos);

        if (t >= 3)
        {
            transform.position= pos;
            t = 0;
        }
        
        
    }
}
