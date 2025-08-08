using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PanelManagment
{
    public class PanelController : MonoBehaviour
    {
        [Header("GameObjects")]
        public GameObject mainMenuPanel;
        public GameObject optionsMenuPanel;
        [SerializeField] private GameObject CLIMB;
        [SerializeField] private GameObject Language;

        [Header("Byte(s)")]
        public byte indexOfPainel { get; private set; }

        [Header("String Arrays")]
        [SerializeField] private string[] panels;
        public string[] Panels => panels;

        [Header("String(s)")]
        public string currentPanel { get; private set; }

        [Header("Scripts instances fields")]
        [SerializeField] private EventSystem m_eventSystem;

        void Start()
        {
            currentPanel = panels[indexOfPainel];
            m_eventSystem.firstSelectedGameObject = CLIMB;
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
                if (indexOfPainel >= 1)
                {
                    indexOfPainel--;
                }
                mainMenuPanel.SetActive(true);
                optionsMenuPanel.SetActive(false);
                m_eventSystem.SetSelectedGameObject(null);
                m_eventSystem.SetSelectedGameObject(CLIMB);
            }
            if (nextPanel == "OptionsMenu")
            {
                optionsMenuPanel.SetActive(true);
                mainMenuPanel.SetActive(false);
                indexOfPainel++;
                m_eventSystem.SetSelectedGameObject(null);
                m_eventSystem.SetSelectedGameObject(Language);
            }

            currentPanel = nextPanel;
        }
    }
}
