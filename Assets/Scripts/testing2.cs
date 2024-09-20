using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class testing2 : MonoBehaviour
{


    public Sprite mySpirst;
    public Image myImage;
    public int cardValue;
    public int secondCardValue;
    public Sprite cardFront;
    public BoardScript first;
    public BoardScript second;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Open()
    {
        myImage.sprite = mySpirst;
    }
    public void Intractable(bool set)
    {
        GetComponent<Button>().interactable = set; //the Button component attached to the same GameObject

    }
   public  void Close()
    {
        first.gameObject.GetComponent<Image>().sprite = cardFront;
        second.gameObject.GetComponent<Image>().sprite = cardFront;
    }
    public IEnumerator ResetCardsDelayed(BoardScript first, BoardScript second)
    {
        yield return new WaitForSeconds(0.6f); // Adjust the delay duration as needed
        first.gameObject.GetComponent<Animator>().SetBool("Unmatched", true);
        second.gameObject.GetComponent<Animator>().SetBool("Unmatched", true);
    }


}
                                                    