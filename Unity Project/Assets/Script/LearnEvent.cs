using UnityEngine;

public class LearnEvent : MonoBehaviour
{
    // 事件 : 在特定時間點以指定次數執行
    // 開始事件 : 播放後執行一次
    // 語法 :
    // 修飾詞 傳回類型 名稱() {  }
    private void Start()
    {
        // 輸出方法(物件);
        print("哈囉，沃德~ :P");
    }

    // 更新事件 : 每秒執行約 60 幀 (60FPS frame per second)
    private void Update()
    {
        print("嗨嗨嗨~");
    }
}
