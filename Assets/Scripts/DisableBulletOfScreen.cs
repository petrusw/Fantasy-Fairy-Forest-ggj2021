using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableBulletOfScreen : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        Debug.Log("nooooooooooooooooooooooooooooooooooo");
    }
}
