using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTimer : MonoBehaviour
{

    public GameObject button;

    public void HideButton()
    {
        StartCoroutine(ShowHideButton());
    }

    public IEnumerator ShowHideButton()
    {
        button.SetActive(false);
        yield return new WaitForSeconds(.25f);
        button.SetActive(true);

    }
}
