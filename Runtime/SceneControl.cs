using UnityEngine;
using UnityEngine.SceneManagement;

namespace ccjie.Tools
{
    /// <summary>
    /// 遊戲場景控制系統，載入或離開
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SceneName"></param>
        public void LoadGame(string SceneName)
        {
            //場景管理器 的 載入場景(場景名稱);
            SceneManager.LoadScene(SceneName);
        }
        /// <summary>
        /// 
        /// </summary>
        public void QuitGame()
        {
            //應用程式 的 離開();
            Application.Quit();
        }
    }

}