using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("追蹤速度"), Range(0, 50)]
    public float speed=1.5f;
    [Header("上下邊界")]
    public Vector2 limitＹ = new Vector2(-5, 5);
    [Header("左右邊界")]
    public Vector2 limitＸ = new Vector2(-5, 5);

}
