using UnityEngine;
using NaughtyAttributes;

public class MoveAdd : MonoBehaviour
{
    [SerializeField, Label("歩数の設定")] private int _step;

    [Button]
    public void MoveAddPosition()
    {
        //オブジェクトの座標を操作するには  　transform.position
        //または transform.localpositionを
        //操作する必要がある
        //transform.up,transform.right,transform.down,transform.left
        //はキャラが回転していても指令方向に移動する
        //+=は元も値に加算する命令文
        //100fで割っているのは、１の移動量が100ドット分なので
        //ドット数/100が進む距離になる
        transform.position += transform.right * _step / 100f;
        
    }
}
