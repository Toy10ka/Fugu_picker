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

    public GameManager gM; // gM�I�u�W�F�N�g(bool)
    public TMPro.TextMeshProUGUI textUI; // ��R���|��TMP�I�u�W�F�N�g�����т���

    // Start is called once 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int remainingItemNumber = GameObject.FindGameObjectsWithTag("Fugu").Length; // �z���Length (�X�J��)


        // GameOver����
        if (gM.isGameover)
        {
            textUI.text = "Game Over�c";
        }

        else
        {
            // �t�O�̕C���ɉ����ĕ\�����e��ς���
            if (remainingItemNumber == 0)
            {
                textUI.text = "Game Clear!";
                gM.isGameClear = true; // �N���A����i���̏������ł�gameover���N�����Ȃ��j
            }
            else
            {
                textUI.text = $"�c��: {remainingItemNumber}�C";
            }
        }
        
   
    }
    
}
