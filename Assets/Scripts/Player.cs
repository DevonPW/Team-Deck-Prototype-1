using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int pose;//0 is neutral/no pose

    [SerializeField] SpriteRenderer spriteRend;

    [SerializeField] Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        pose = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //check input
        if (Input.GetButton("Pose1")) {
            pose = 1;
            spriteRend.sprite = sprites[1];
        }
        else {
            pose = 0;
            spriteRend.sprite = sprites[0];
        }
    }

}
