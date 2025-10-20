using UnityEngine;

public class ChangePosition : MonoBehaviour
{
  
    private void Start()
    {
        
    }
    void Update()
    {
      if(Input.GetMouseButtonUp(0))
        {
            float randomX = Random.Range(-10f, 10f);
            float randomY = Random.Range(-5f, 5f);

            // オブジェクトの位置を更新する
            transform.position = new Vector3(randomX, randomY, 0);
        }
    }
}