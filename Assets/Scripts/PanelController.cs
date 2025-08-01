using UnityEngine;

namespace PanelManagment
{
    public class PanelController : MonoBehaviour
    {
        public GameObject mainMenuPanel;
        public GameObject optionsMenuPanel;

        /// <summary>
        /// Troca de painéis utilizando uma comparação de string simples
        /// </summary>
        /// <param name="nextPanel">String que será comparada</param>
        /// <example>
        /// <code>
        /// public void switchPanel(string nextPanel)
        /// {
        ///      mainMenuPanel.SetActive(nextPanel == "MainMenu");
        ///      optionsMenuPanel.SetActive(nextPanel == "OptionsMenu");
        /// }
        /// </code>
        /// </example>
        public void switchPanel(string nextPanel)
        {
            mainMenuPanel.SetActive(nextPanel == "MainMenu");
            optionsMenuPanel.SetActive(nextPanel == "OptionsMenu");
        }
    }
}
