using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{

    [SerializeField] private Sprite redDefaultLook;
    [SerializeField] private Sprite redKingedLook;

    [SerializeField] private Sprite grayDefaultLook;
    [SerializeField] private Sprite grayKingedLook;

    private string team = "red";
    private bool isKing = false;
    private bool appearenceUpdated = true;

    SpriteRenderer checkerrender;

    private void Start()
    {
       checkerrender = this.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (appearenceUpdated == true) {
            if (isKing == true)
            {
                switch (team)
                {
                    case "red":
                        checkerrender.sprite = redKingedLook;
                        break;
                    case "gray":
                        checkerrender.sprite = redDefaultLook;
                        break;
                }
            }
            else {
                switch (team)
                {
                    case "red":
                        checkerrender.sprite = redDefaultLook;
                        break;
                    case "gray":
                        checkerrender.sprite = grayDefaultLook;
                        break;
                }
            }

        }
    }
    public void promoteToKing()
    {
        this.isKing = true;
        appearenceUpdated = true;
    }

    public void setTeam(string aTeam)
    {
        this.team = aTeam;
        appearenceUpdated = true;
    }
}
