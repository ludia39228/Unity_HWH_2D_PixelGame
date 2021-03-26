using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("追蹤速度"), Range(0, 50)]
    public float speed=1.5f;
    [Header("上下邊界")]
    public Vector2 limitＹ = new Vector2(-5, 5);
    [Header("左右邊界")]
    public Vector2 limitＸ = new Vector2(-5, 5);
    [Header("玩家")]
    public Transform player;

    

    private void Update()
    {
        Track();
    }

    ///<summary>
    ///追蹤
    ///</summary>
    
    private void Track()
    {
        Vector3 posCam = transform.position;   //取得 攝影機座標
        Vector3 posPla = player.position;      //取得 玩家座標

        posCam = Vector3.Lerp(posCam, posPla, 0.5f*speed*Time.deltaTime);
        posCam.z = -10;

        transform.position = posCam;         //更新攝影機的座標

    }

}
