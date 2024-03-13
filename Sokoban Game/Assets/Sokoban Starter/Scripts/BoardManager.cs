using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    BaseState currentState;
    public BaseState DetectClingy = new Clingy();
    public BaseState DetectWall = new Wall();
    public BaseState DetectSticky = new Sticky();
    public BaseState DetectSlick = new Slick();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
