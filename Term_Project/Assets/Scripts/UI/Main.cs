using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DoExitGame()
    {
        Application.Quit();
    }

    /* Start 버튼 클릭 */
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Forest");
    }

    /* Quit 버튼 클릭 */
    public void OnClickQuitButton()
    {
        DoExitGame();
    }
}