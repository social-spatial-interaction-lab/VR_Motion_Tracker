using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UXF;

public class ClickFinishButton : XRBaseInteractable
{
    public UXF.Session session;
    public TextMeshPro buttonText;
    public void Selected()
    {
        buttonText.SetText("Selected");
        session.End();
        buttonText.SetText("Session Ended");
    }
}