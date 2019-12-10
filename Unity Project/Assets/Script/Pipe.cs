// 子類別 繼承 父類別
// 可享有所有父類別的成員
public class Pipe : Ground
{
    // 前提 : 需要Mesh Renderer 元件
    // 在所有相機看不到呼叫一次
    

    private void OnBecameInvisible()
    {
        print("看不到");

        Destroy(gameObject, 2);  //  刪除(物件，延遲事件) gameObject 此物件
    }

    // 在所有相機看到呼叫一次
    private void OnBecamevisible()
    {
        print("看到了");
    }
}
