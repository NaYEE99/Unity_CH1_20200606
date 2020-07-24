
using UnityEngine;
using UnityEngine.SceneManagement;      //使用場景管理API

/// <summary>
/// 場景控制器 功能：切換場景(遊戲畫面/離開遊戲)
/// </summary>
public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit();         //API：Application.離開遊戲
        
        
    }                               //使用此敘述段即可關閉遊戲畫面，Unity測試時不會有作用。

    /// <summary>
    /// 載入場景
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("遊戲場景");     //API：場景管理.載入場景("場景名稱");
                                                //此為無延遲版本，會有按妞音效撥放不完全
    }
         
    /// <summary>
    /// 延遲載入遊戲
    /// </summary>
    public void DelayLoadScene()
    {
        Invoke("LoadScene", 1);                 //延遲呼叫API：Invoke("方法名稱", 延遲時間F)

    }

    /// <summary>
    /// 延遲離開遊戲
    /// </summary>
    public void DelayQuit()
    {
        Invoke("Quit", 1);                     //延遲呼叫API：Invoke("方法名稱", 延遲時間F)

    }

}
