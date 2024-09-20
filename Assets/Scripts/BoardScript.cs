using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardScript : MonoBehaviour
{
    public Sprite[] _sprites;
    public Image[] _firstLeftImages;
    public Image[] _secondRightImages;
    public Transform _gridParent;
    public Button[] _firstButton;
    public testing2 firstClicked;
    public testing2 secondclicked;
    public Text scoreText;
    int score;
    bool nonClicked = true;
    public Sprite cardFront;
    
    // Start is called before the first frame update
    void Start()
    {
        ShowCards();

    }

    // Update is called once per frame
    void Update()
    {
        /* if (num % 2 == 0)
         {
             Debug.Log("its is even Number");

         }
         else
             Debug.Log("it is Odd Number");*/
    }

   
    public void ShowCards()
    {
        for (int i = 0; i < _firstLeftImages.Length; i++)// 0 to _firstimages of length means array of lenght of applied 
        {
            int _randomValue = Random.Range(0, _sprites.Length);
            _firstLeftImages[i].GetComponent<testing2>().mySpirst = _sprites[_randomValue]; //sending the sprite to another script = sprites of random value and its applying to firdtImages array
            _secondRightImages[i].GetComponent<testing2>().mySpirst = _sprites[_randomValue];//same
           
        }

        _ShuffleImages();
    }
    public void _ShuffleImages()
    {
        for (int i = 0; i < 12; i++)
        {
            _gridParent.GetChild(i).SetSiblingIndex(Random.Range(0, 12));// gridparent of childs....(i) means 1,2,3...12;,setting to siblings range of 0,12;


        }

    }                             //1
    public void _Buttoncliked(testing2 test)//1)--2.
    {
      
        if (nonClicked)
        {
            firstClicked = test; //storing the first clicked amount and converting to another script 
            Debug.Log(firstClicked);  
            firstClicked.Intractable(false);
            nonClicked = false;   
        }
        else
        {
            secondclicked = test;
            secondclicked.Intractable(false);
            Debug.Log(secondclicked);
            CompareWin();
        }
    }
    public void CompareWin()
    {
       
        if (firstClicked.cardValue == secondclicked.secondCardValue)
        {
            score++;
            scoreText.text = score.ToString("0");
            if(score>0)
            {
                scoreText.color = Color.green;
            }
            if (score == 0)
            {
                scoreText.color = Color.black;
            }
        }
        else
        {
            
            score--;
            scoreText.text=score.ToString("0");
/*            StartCoroutine(firstClicked.ResetCardsDelayed(firstClicked, secondclicked));*/
            Debug.Log("false");
            firstClicked.Intractable(true);
            secondclicked.Intractable(true);
            /*firstClicked.gameObject.GetComponent<Image>().sprite = cardFront;
            secondclicked.gameObject.GetComponent<Image>().sprite = cardFront;
            firstClicked.gameObject.GetComponent<Animator>().SetBool("Unmatched", true);
            secondclicked.gameObject.GetComponent<Animator>().SetBool("Unmatched", true);*/
        }
        nonClicked = true;
    }
}
