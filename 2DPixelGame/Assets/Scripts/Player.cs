﻿using UnityEngine;

public class Player : MonoBehaviour
{
    //修飾詞 類型 名稱(指定值);


    //類型 四大類型
    //整數 int
    //浮點數 float
    //布林值 bool true是、false否
    //字串 string
    [Header("等級")]
    [Tooltip("這是角色的等級")]
    public int Lv = 1;
    [Header("移動速度"),Range(0,300)]
    public float speed = 10.5f;
    [Header("角色是否死亡" )]
    public bool isDead = false;
    [Header("角色名稱"),Tooltip("這是角色的名稱")]
    public string cName = "貓咪";
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("變形元件")]
    public Transform tra;

    //方法語法 Method-儲存複雜的程式區塊或演算法
    //修飾詞 類型 名稱(){程式區塊或演算法}
    //void無類型

    /// <summary>
    /// 移動
    /// </summary>

    private void Move()
    {
        print("移動");

        float h = joystick.Horizontal;
        print("水平:" + h);

        float v = joystick.Vertical;
        print("垂直:" + v);

        tra.Translate(3, 0, 0);
    }
    private void Attack()
    {

    }
    private void Hit()
    {

    }
    private void Dead()
    {

    }

    //事件-特定時間會執行的方法
    //開始事件：撥放後執行一次
    private void Start()
    {
        //呼叫方法
        //方法名稱();
        Move();
    }
    //更新事件：大約一秒執行六十次 60FPS
    private void Update()
    {
        Move();

    }
}
