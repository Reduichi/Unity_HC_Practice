using UnityEngine;

public class Ground : MonoBehaviour
{
    // static 靜態 隱藏
    // 此類別共用 包含子類別
    // [Header("速度"), Range(0, 100)]
    public static float speed = 3f;
    [Header("變形")]
    public Transform move;

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void Move()
    {
        move.Translate(-speed *Time.deltaTime , 0, 0);
        // Time.deltaTime 一幀的時間
    }

    private void Update()
    {
        Move();
    }
}
