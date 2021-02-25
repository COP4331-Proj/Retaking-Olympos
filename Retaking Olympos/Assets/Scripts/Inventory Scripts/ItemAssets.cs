using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    // Singleton patern to create only one instance of this class
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite swordSprite;
    public Sprite helmetSprite;
    public Sprite chestplateSprite;
    public Sprite pantsSprite;
    public Sprite bootsSprite;


}
