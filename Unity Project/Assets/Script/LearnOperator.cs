using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3;
    public int c = 9, d = 1;

    private void Start()
    {
        // 數學運算子
        // +  -  *  /  %
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);
        print(6 / 2 * (2 + 1));

        a = a + 1;    // 等號右邊先執行再存回左邊
        print(a++);   // 先輸出再執行遞增
        print(++a);   // 先執行遞增再輸出

        b = b + 10;
        b += 10;      // 適用+  -  *  /  %

        // 比較運算子
        // 結果是布林植
        print(c > d);     // T
        print(c < d);     // F
        print(c >= d);    // T
        print(c <= d);    // F
        print(c == d);    // F
        print(c != d);    // T
    }
}
