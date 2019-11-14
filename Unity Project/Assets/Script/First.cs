using UnityEngine; //引用Unity API

//類別 類別名稱
public class First : MonoBehaviour 
{
    // 定義欄位 Field(宣告變數)
    // 語法 :
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // 私人 private  - 隱藏(預設)
    // 公開 public   - 顯示

    public int level = 1;              // 整數 預設 0
    public float speed = 10.5f;        // 浮點數 預設 0
    public string prop = "藍色藥水";   // 字串 預設 ""
    public bool mission = true;        //布林植 預設 false

    // 屬性
    // 語法 : [屬性名稱(屬性內容)]
    // [標題("標題內容")]

    [Header("血量")]
    public int hp = 100;
    [Header("跳越高度")]
    public float jump = 99.9f;

    // [提示("提示內容")]
    [Header("死亡")]
    [Tooltip("用來紀錄玩家是否死亡，打勾:死亡，取消:沒死。")]
    public bool dead;
    // [範圍(最小值，最大值)]
    [Header("魔力"),Range(0,999)]
    public int mp = 50;

}
