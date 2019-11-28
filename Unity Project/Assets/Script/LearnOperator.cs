using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3;
    public int c = 9, d = 1;
    public int apple = 5 , key = 2;
    public int coin = 3, bomb = 1;

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

        // 邏輯運算子
        // 結果是布林植
        // 並且 &&
        // 規則 : 只要有一個 false 就會傳回 false
        print(true && true);      // T
        print(true && false);     // F
        print(false && true);     // F
        print(false && false);    // F

        // 或者 ||
        // 規則 : 只要有一個 false 就會傳回 false
        print(true || true);      // T
        print(true || false);     // T
        print(false || true);     // T
        print(false || false);    // F

        // 相反(顛倒)
        // 作用 : 將布林植變相反
        print(!true);
        print(!false);

        // 任務 : 取得十個蘋果與五個金幣
        print(apple >= 10 && coin >= 5);

        // 任務 : 取得一個鑰匙或者兩個炸彈
        print(key >= 1 || bomb >= 2);

    }
}
