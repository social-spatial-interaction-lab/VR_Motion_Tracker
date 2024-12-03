using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UXF;

public class ClickStartButton : XRBaseInteractable
{
    public UXF.Session session;
    public TextMeshPro buttonText;
    public void Selected()
    {
        buttonText.SetText("Selected");
        session.CreateBlock(1);
        session.FirstTrial.Begin();
        Debug.Log("Beginning session...");

        buttonText.SetText("Recording...");
    }
}