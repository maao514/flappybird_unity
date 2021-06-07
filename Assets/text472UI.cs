using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text472UI : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public void showStartUI()
    {
        canvasGroup.alpha = 1;
    }
    public void hideStartUI()
    {
        canvasGroup.alpha = 0;
    }

}
