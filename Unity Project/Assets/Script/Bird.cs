﻿using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 2000)]
    public int jump = 100;
    [Header("是否死亡")]
    public bool dead;

    public GameObject goScore, goGM;
    [Header("剛體")]
    public Rigidbody2D r2d;

    public GameManager gm;

    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {
        if (dead) return; // 跳出此方法

        // 如果 按下 左鍵
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("按下左鍵");

            // 分數 顯示
            // GM 顯示
            goScore.SetActive(true);
            goGM.SetActive(true);

            r2d.gravityScale = 1;                // 剛體.重力 = 1
            r2d.Sleep();                         // 剛體.睡覺
            r2d.AddForce(new Vector2(0,jump));   // 剛體.增加推力(二維向量)
        }
        print(r2d.velocity);
        r2d.SetRotation(3*r2d.velocity.y);       // 剛體.設定角度(角度)
    }

    /// <summary>
    /// 小雞死亡功能
    /// </summary>
    private void Dead()
    {
        dead = true;
        gm.GameOver();
    }

    /// <summary>
    /// 小雞通過水管
    /// </summary>
    private void PassPipe()
    {

    }

    private void Update()
    {
        Jump();
    }

    // 碰撞事件 : 碰到其他碰撞器開始執行一次 (碰到物件的碰撞資訊)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);

        Dead();
    }

    // 觸發事件 : 觸發到其他碰撞器開始執行一次 (針對勾選 IsTrigger 的物件)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Dead();
    }
}
