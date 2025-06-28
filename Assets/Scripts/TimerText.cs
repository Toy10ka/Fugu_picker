using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerText : MonoBehaviour
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

    private float _remainingTime; // 残り時間

    [SerializeField] TMPro.TextMeshProUGUI _timer_text; // 残り時間表示
    [SerializeField] float _startTime = 20f; // 初期時間
    [SerializeField] public GameManager gM; // gMへの参照

    // Start is called once 
    void Start()
    {
        _remainingTime = _startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (gM.isGameover || gM.isGameClear) return; // クリアかアウトなら抜け

        // 時間経過計算
        _remainingTime -= Time.deltaTime; 

        // 時間切れ処理
        if (_remainingTime <= 0f) 
        {
            _remainingTime = 0f;
            gM.isGameover = true;

            _timer_text.text = "Time up!";
        }
        else
        {
            // 5秒以内での処理
            if (_remainingTime <= 5f)
                // だんだん赤くする
                _timer_text.color = Color.Lerp(Color.red, Color.white, Mathf.PingPong(Time.time, 1));

            else
            {
                _timer_text.color = Color.white; // 通常時は白
            }

            // 秒表示更新
            int seconds = Mathf.CeilToInt(_remainingTime);
            _timer_text.text = $"残り{seconds}秒";

        }

    }
    
}
