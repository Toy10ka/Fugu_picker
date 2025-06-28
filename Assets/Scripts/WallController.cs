using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
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

    // public fileds
    public GameManager gM; // GameManagerの空コンポ(false or true)

    // Start is called once 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        // Playerが当たった & クリアしていない
        if (col.gameObject.CompareTag("Player") && !gM.isGameClear)
        {
            gM.isGameover = true; // gMのゲームオーバー判定をtrueに
        }
    }

}
