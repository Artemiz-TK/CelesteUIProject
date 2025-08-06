using UnityEngine;

namespace PanelManagment
{
    public class PanelController : MonoBehaviour
    {
        public GameObject mainMenuPanel;
        public GameObject optionsMenuPanel;

        public byte indexOfPainel;
        [SerializeField] private string[] panels;
        public string[] Panels => panels;
        public string currentPanel { get; private set; }

        void Start()
        {
            currentPanel = panels[indexOfPainel];
        }

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
            if (nextPanel == "MainMenu")
            {
                mainMenuPanel.SetActive(true);
                optionsMenuPanel.SetActive(false);
                indexOfPainel--;
            }
            else if (nextPanel == "OptionsMenu")
            {
                optionsMenuPanel.SetActive(true);
                mainMenuPanel.SetActive(false);
                indexOfPainel++;
            }
        }
    }
}
