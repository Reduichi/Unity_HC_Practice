using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int score;
    [Header("最高分數")]
    public int scoreHeight;
    [Header("水管")]
    public GameObject pipe; // GameObject 可以存放預置物以及場景上的物件
    [Header("介面群組")]
    public GameObject goUI;
    [Header("分數介面")]
    public Text textScore;
    public Text textHeight;


    /// <summary>
    /// 生成水管功能
    /// </summary>
    public void SpawnPipe()
    {
        // 因為有繼承此類別才可簡寫
        // Object.Instantiate(pipe);

        // 浮點數 = 隨機.靜態方法(最小，最大)
        float y = Random.Range(-0.9f , 0.9f);

        // 三維向量 Vector3 - x,y,z
        Vector3 pos = new Vector3(4.5f , y , 0);

        // 四元數 Quaternion - x,y,z,w
        Quaternion rot = new Quaternion(0, 0, 0, 0);
        Instantiate(pipe, pos, rot);
    }

    /// <summary>
    /// 加分功能
    /// </summary>
    /// <param name="add">要添加的分數</param>
    public void AddScore(int add)
    {
        score = score + add;
        // textScore.text = score + "";
        textScore.text = score.ToString();

        SetHeightScore();
    }

    /// <summary>
    /// 設定最高分數
    /// </summary>
    private void SetHeightScore()
    {
        // 如果目前分數 > 最高分數
        if (score > scoreHeight)
        {
            // 最高分數 = 目前分數
            scoreHeight = score;

            PlayerPrefs.SetInt("最高分數", scoreHeight);
        }
        textHeight.text = scoreHeight.ToString();  // 整數.轉字串
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        goUI.SetActive(true);
        Ground.speed = 0;
    }

    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void Replay()
    {
        // Application.LoadLevel("遊戲場景");  // 應用程式.載入關卡("關卡名稱") 舊版 API
        SceneManager.LoadScene("遊戲場景");    // 場景管理.載入場景("場景名稱") 新版 API
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Exit()
    {
        Application.Quit();                 // 應用程式.離開遊戲
    }

    private void Start()
    {
        // SpawnPipe();
        // 重複延遲物件生產時間
        InvokeRepeating("SpawnPipe", 0, 2.5f);

        // 取得最高分數
        scoreHeight = PlayerPrefs.GetInt("最高分數");
        textHeight.text = scoreHeight.ToString();  // 整數.轉字串
        Ground.speed = 3f; //靜態欄位會保留上次的值，必須要重新設定
    }
}
