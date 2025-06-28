using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Remaindingfugu_text : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    #endregion

    #region public property

    #endregion

    #region private property

    #endregion

    #region public method

    #endregion

    #region private method

    #endregion

    // public fields

    public GameManager gM; // gMオブジェクト(bool)
    public TMPro.TextMeshProUGUI textUI; // 空コンポにTMPオブジェクトを結びつける

    // Start is called once 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int remainingItemNumber = GameObject.FindGameObjectsWithTag("Fugu").Length; // 配列のLength (スカラ)


        // GameOver判定
        if (gM.isGameover)
        {
            textUI.text = "Game Over…";
        }

        else
        {
            // フグの匹数に応じて表示内容を変える
            if (remainingItemNumber == 0)
            {
                textUI.text = "Game Clear!";
                gM.isGameClear = true; // クリア判定（この条件下ではgameoverを起こさない）
            }
            else
            {
                textUI.text = $"残り: {remainingItemNumber}匹";
            }
        }
        
   
    }
    
}
