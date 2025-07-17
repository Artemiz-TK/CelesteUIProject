using UnityEngine;
using System;
using System.Collections;
using TMPro;

public class TextColorChange : MonoBehaviour
{
    public TextMeshProUGUI textmeshpro;
    public Animator animator;

    public void changeTextColorToGreen()
    {
        StartCoroutine(changeColorWithDelay());
    }

    private IEnumerator changeColorWithDelay()
    {
        // animator.SetBool("optionsActive", true);

        yield return new WaitForSeconds(0.9f);

        // for (int i = 100; i <= 0; i--)
        // {
        //     textmeshpro.color = new Color(0, i, 0, 255);
        //     yield return new WaitForSeconds(1.0f);
        // }

        // animator.SetBool("optionsActive", false);
    }
}
