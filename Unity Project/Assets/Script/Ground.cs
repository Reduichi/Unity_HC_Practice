using UnityEngine;

public class Ground : MonoBehaviour
{
    [Header("速度"), Range(0, 100)]
    public float speed = 1f;
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
