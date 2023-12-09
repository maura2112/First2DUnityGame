using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_OpenLink : MonoBehaviour
{
    public void OpenFacebook()
    {
        Application.OpenURL("https://www.facebook.com/btrg2112/");
    }
    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/maura.2112/");
    }
    public void OpenFeedback()
    {
        Application.OpenURL("https://forms.gle/7mnejvqsBp8L1ViP9");
    }
}
