using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public AudioClip buttonClickSound;

    private void OnMouseDown()
    {
        SoundManager.instance.PlaySoundEffect(buttonClickSound);
    }
}
