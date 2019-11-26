using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform tranA;
    public Transform tranB;
    public SpriteRenderer spriteA;

    private void Start()
    {
        print("輸出");

        // 靜態屬性 : 類別.屬性
        print(Random.value);

        // 練習取得PI
        print(Mathf.PI);

        // 靜態方法 : 類別.方法(對應的引數);
        print("隨機範圍 : " + Random.Range(50.5f, 100.9f));

        // object 任何類型 : int、float、string、bool
        Debug.Log(true);
        Debug.LogWarning("警告");
        Debug.LogError("錯誤");

        // 非靜態屬性 : 實體類別.屬性
        print(tranA.position);
        print(tranB.position);
        // 存放非靜態屬性
        tranA.position = new Vector3(-1, 0, 0);

        spriteA.flipX = true;
    }

    private void Update()
    {
        // 輸入.按鍵名稱
        print(Input.inputString);

        print(Input.GetKeyDown("s"));
        // 練習：偵測玩家有沒有輸入ｓ

        // 非靜態方法 : 實體類別.方法(對應的引數)
        tranA.Rotate(0, 0, 10);

    }
}
