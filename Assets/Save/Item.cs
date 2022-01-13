using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public HashSet<string> Items { get; private set; } = new HashSet<string>();
}
