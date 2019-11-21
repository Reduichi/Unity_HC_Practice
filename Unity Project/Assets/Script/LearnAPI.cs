using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    private void Start()
    {
        print("輸出");

        // 靜態屬性 : 類別.屬性
        print(Random.value);

        // 練習取得PI
        print(Mathf.PI);

        // 靜態方法 : 類別.方法(對應的參數);
        print("隨機範圍 : " + Random.Range(50.5f, 100.9f));

        // object 任何類型 : int、float、string、bool
        Debug.Log(true);
        Debug.LogWarning("警告");
        Debug.LogError("錯誤");
    }

    private void Update()
    {
        // 偵測輸入的文字
        print(Input.inputString);
        // 練習：偵測玩家有沒有輸入ｓ

    }
}
