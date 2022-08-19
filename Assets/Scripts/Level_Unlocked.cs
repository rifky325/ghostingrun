using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Unlocked : MonoBehaviour
{
    public void levelUnlocked(int nextlevel)
    {
        PlayerPrefs.SetInt("levelUnlocked", nextlevel);
    }
}