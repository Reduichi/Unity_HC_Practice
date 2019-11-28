using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool open;
    public int score;
    public int click;

    private void Start()
    {
        // 判斷式 if (switch)
        // 語法 :
        // if(布林植) { 當 if ( ) 布林植為 true 執行這裡 }

        if (true)
        {
            print("嗨~");
        }
    }

    private void Update()
    {
        // if ( ) 布林值為 true 會執行 if { }
        if(open)
        {
            print("開門!");
        }
        // if ( ) 布林值為 false 會執行 else { } (否則)
        else
        {
            print("關門!");
        }

        if (score >= 60)
        {
            print("及格了");
        }
        else if (score >= 40)
        {
            print("你可以補考");
        }
        else if (score >= 30)
        {
            print("你可以付錢補考");
        }
        else
        {
            print("不及格");
        }

        if(click >= 150)
        {
            print("攻擊10倍");
        }
        else if(click >= 100)
        {
            print("攻擊5倍");
        }
        else if(click >= 50)
        {
            print("攻擊2倍");
        }
    }

}
