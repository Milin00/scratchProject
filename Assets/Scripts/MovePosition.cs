using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public float x;
    public float y;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(x/100f, y/100f);
    }
}
