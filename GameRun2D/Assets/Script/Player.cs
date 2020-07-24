
using System;
using UnityEngine;

//引用資料庫區域

public class Player : MonoBehaviour
{


    #region Field zom 欄位區域
    //定義基本欄位

    [Header("血量"), Tooltip("初始值暫定為200，可調整"), Range(0, 500)]
    public int hp = 200;

    [Header("速度"), Tooltip("角色奔跑的速度值"), Range(-100, 100)]
    public float speed = 10;

    [Header("跳躍高度"), Tooltip("角色跳躍的高度"), Range(0, 1000)]
    public float jumpHeight;

    [Header("金幣數量"), Tooltip("所得到的金幣數量"), Range(0, 100)]
    public int coin;

    [Header("死亡判定"), Tooltip("一定血量下也視同死亡")]
    public bool deadline;

    [Header("死亡"), Tooltip("ture = 腳色死亡")]
    public bool dead;


    [Header("動作判定")]
    public int lastAction;
    public int nowAction;


    [Header("音效區域")]  //欄位連用在同一個屬性下，會使該屬性下的欄位緊密靠攏，可作為整理方法之一。
    public AudioClip soundJump;     //跳躍音效
    public AudioClip soundSlide;    //滑行音效
    public AudioClip soundHit;      //受傷音效
    public AudioClip soundCoin;     //吃金幣音效
    public AudioClip soundDead;     //死亡音效


    //欄位區域結束
    #endregion


    //=====我是分隔線=====


    #region Method zom 方法區域


    /// <summary>
    /// 跳躍
    /// 功能說明：播放音效、執行動畫、角色向上移動
    /// </summary>
    private void Jump()
    {
        print("1129550");
    }

    /// <summary>
    /// 滑行
    /// 功能說明：播放音效、執行動畫、角色碰撞範圍縮小
    /// </summary>
    private void Slide()
    {
        print("123");
    }

    /// <summary>
    /// 受傷
    /// 功能說明：播放音效、執行動畫、扣除定值血量
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    /// 獲得金幣
    /// 功能說明：播放音效、使金幣消失、計數器增加
    /// </summary>
    private void Coin()
    {

    }

    /// <summary>
    /// 死亡線判定
    /// 功能說明：播放音效、執行動畫、結束遊戲
    /// </summary>
    private void DeadLine()
    {

    }

    /// <summary>
    /// 角色死亡
    /// 功能說明：播放音效、執行動畫、結束遊戲
    /// </summary>
    private void Dead()
    {

    }


    //方法區域結束
    #endregion


    //=====我是分隔線=====


    #region Event zom 事件區域

    //開始時執行一次
    //初始化設定：
    private void Start()
    {
        



    }


    //持續以60次/秒的頻率偵測更新
    //持續更新事件：
    //              跳躍、滑行、受傷、吃金幣、死亡
    private void Update()
    {
        




    }


    //事件區域結束
    #endregion



}

