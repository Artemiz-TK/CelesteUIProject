using PanelManagment;
using UnityEngine;

namespace ButtonAnimationManagment
{
    public class ButtonPositionAnimation : MonoBehaviour
    {
        public GameObject CLIMB;
        public GameObject Options;
        public GameObject Credits;
        public GameObject Exit;

        private PanelController panelController;

        public void ButtonPositionStartAnimation(string buttonName)
        {
            if (buttonName == CLIMB.name)
            {
                // panelController.switchPanel();
            }
        }
    }
}