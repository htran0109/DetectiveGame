﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public static int MAX_TEXT_LENGTH = 200;
    public string name;
    public string[] sentences;

    public Dialogue(string[] sentences)
    {
        this.sentences = sentences;
    }
}
