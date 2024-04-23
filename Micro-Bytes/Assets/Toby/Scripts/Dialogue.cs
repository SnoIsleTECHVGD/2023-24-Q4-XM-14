using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public DialoguePiece[] conversation;
}

public struct DialoguePiece
{
    public string name;
    public Sprite icon;
    [TextArea(3, 10)]
    public string sentence;
}