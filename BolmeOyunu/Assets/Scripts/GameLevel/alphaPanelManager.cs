﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class alphaPanelManager : MonoBehaviour
{
    public GameObject alphaPanel;
    // Start is called before the first frame update
    void Start()
    {
        alphaPanel.GetComponent<CanvasGroup>().DOFade(0, 2f);
    }

}
