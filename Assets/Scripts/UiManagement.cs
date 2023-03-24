using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManagement : MonoBehaviour
{
    #region Exposed

    [SerializeField] GameObject tt;

    #endregion

    #region Unity Lifecycle
    
    void Start()
    {

    }

    void Update()
    {

    }

    #endregion

    #region Methods
    
    public void RestartGame()
    {
        //Time.timeScale = 1f;
        Debug.Log("tot");
        SceneManager.LoadScene(0);
    }

    #endregion

    #region Private & Protected

   

    #endregion
}
