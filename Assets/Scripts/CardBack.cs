using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBack : MonoBehaviour {

    public bool backUp = false;
    public Sprite frontSprite;
    public Sprite backSprite;

    void Start() {
        if (frontSprite == null)
            frontSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

}
