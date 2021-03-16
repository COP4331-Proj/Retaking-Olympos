using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script that holds references to all the item sprites, attatched to SpriteAssets game object
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

    public Sprite swordSprite2;
    public Sprite helmetSprite2;
    public Sprite bootsSprite2;

    public Sprite swordSprite3;
    public Sprite helmetSprite3;
    public Sprite chestplateSprite3;
    public Sprite pantsSprite3;
    public Sprite bootsSprite3;

    public Sprite swordSprite4;
    public Sprite helmetSprite4;
    public Sprite chestplateSprite4;
    public Sprite pantsSprite4;
    public Sprite bootsSprite4;

    public Sprite swordSprite5;
    public Sprite helmetSprite5;
    public Sprite chestplateSprite5;
    public Sprite pantsSprite5;
    public Sprite bootsSprite5;

}
