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

    private float _remainingTime; // �c�莞��

    [SerializeField] TMPro.TextMeshProUGUI _timer_text; // �c�莞�ԕ\��
    [SerializeField] float _startTime = 20f; // ��������
    [SerializeField] public GameManager gM; // gM�ւ̎Q��

    // Start is called once 
    void Start()
    {
        _remainingTime = _startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (gM.isGameover || gM.isGameClear) return; // �N���A���A�E�g�Ȃ甲��

        // ���Ԍo�ߌv�Z
        _remainingTime -= Time.deltaTime; 

        // ���Ԑ؂ꏈ��
        if (_remainingTime <= 0f) 
        {
            _remainingTime = 0f;
            gM.isGameover = true;

            _timer_text.text = "Time up!";
        }
        else
        {
            // 5�b�ȓ��ł̏���
            if (_remainingTime <= 5f)
                // ���񂾂�Ԃ�����
                _timer_text.color = Color.Lerp(Color.red, Color.white, Mathf.PingPong(Time.time, 1));

            else
            {
                _timer_text.color = Color.white; // �ʏ펞�͔�
            }

            // �b�\���X�V
            int seconds = Mathf.CeilToInt(_remainingTime);
            _timer_text.text = $"�c��{seconds}�b";

        }

    }
    
}
