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
    public bool isGameover = false; // 他のスクリプトから見れるように
    public bool isGameClear = false;

    void Restart()
    {
        SceneManager.LoadScene(0); // シーンをリセット
        isGameover = false; // 判定もリセット
        isGameClear = false; // クリアフラグ
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
            Invoke("Restart", 2); // 2秒後にリセット
        }
    }
    
}
