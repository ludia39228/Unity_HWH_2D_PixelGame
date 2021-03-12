using UnityEngine;

public class Player : MonoBehaviour
{
    //修飾詞 類型 名稱(指定值);


    //類型 四大類型
    //整數 int
    //浮點數 float
    //布林值 bool true是、false否
    //字串 string
    [Header("等級")]
    public int Lv = 1;
    [Range(0,300)]
    public float speed = 10.5f;
    public bool isDead = false;
    [Tooltip("這是角色的名稱")]
    public string cName = "貓咪";


}
