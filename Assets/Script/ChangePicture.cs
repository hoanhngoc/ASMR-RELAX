using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePicture : MonoBehaviour
{
    public Sprite[] sprites;
    private int currentSpriteIndex = 0;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateSprite();
    }
    private void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.K))
        {
            ChangeSprite();

        }*/
    }
    public void ChangeSprite()
    {
       
        currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
        UpdateSprite();

        
    }

    private void UpdateSprite()
    {
        spriteRenderer.sprite = sprites[currentSpriteIndex];
    }
}
