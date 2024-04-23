using UnityEngine;

public struct DialoguePiece
{
    public string name;
    public Sprite icon;
    [TextArea(3, 10)]
    public string sentence;
}