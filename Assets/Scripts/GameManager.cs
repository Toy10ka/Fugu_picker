using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
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
    public bool isGameover = false; // ���̃X�N���v�g���猩���悤��
    public bool isGameClear = false;

    void Restart()
    {
        SceneManager.LoadScene(0); // �V�[�������Z�b�g
        isGameover = false; // ��������Z�b�g
        isGameClear = false; // �N���A�t���O
    }

    // Start is called once 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameover)
        {
            Invoke("Restart", 2); // 2�b��Ƀ��Z�b�g
        }
    }
    
}
