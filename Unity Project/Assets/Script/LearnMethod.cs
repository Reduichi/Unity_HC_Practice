using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 定義方法 Method (宣告函式、功能)
    // 語法 :
    // 修飾詞 方法傳回類型 方法名稱 () {  }
    // void 無傳回
    private void Test()
    {

    }

    /// <summary>
    /// 開車子
    /// </summary>
    private void Drive()
    {
        print("車子正在往前開，時速 : 999");  
    }

    private void Start()
    {
        //呼叫方法
        Drive();
        Drive();
    }

}
