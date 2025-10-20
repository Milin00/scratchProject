using UnityEngine;
using NaughtyAttributes;



public class RotateAdd : MonoBehaviour
{
    [SerializeField, Label("回転角度の設定")] private int _Rotate;

    [Button("実行")]

    public void AddRotate()
    {
        transform.Rotate(0, 0, _Rotate);
    }
}
