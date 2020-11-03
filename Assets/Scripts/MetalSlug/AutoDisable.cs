using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDisable : MonoBehaviour
{
    public float AutoDisableTime = 2f;

    private void OnEnable()
    {
        StartCoroutine(AutoDisableWithTime());
    }

    IEnumerator AutoDisableWithTime()
    {
        yield return new WaitForSeconds(AutoDisableTime);

        gameObject.SetActive(false);
    }
}
