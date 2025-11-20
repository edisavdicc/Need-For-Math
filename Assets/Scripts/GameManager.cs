using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text questionText;
    public TMP_Text button1;
    public TMP_Text button2;
    public TMP_Text button3;
    public TMP_Text button4;

    public Rigidbody raceCar;
    public float speed;

    int score = 0;
    int question;

   



    
    void wrongAnswer()
    {
        speed = speed - 10;
    }

   
   
    public void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        questionText.text = "1/4+2/4 =";
        button1.text = "4/4";
        button2.text = "2/4";
        button3.text = "1/4";
        button4.text = "3/4";
        question = 1;
        raceCar.GetComponent<Rigidbody>();
    }


    public void Answer(int answer)
    {
        if (question == 1)
        {

            if (answer == 4)
            {
                score = score + 1;
                speed = speed + 15;

            }
            else
            {
                wrongAnswer();
            }
            
            questionText.text = "6/8-4/8 =";
            button1.text = "5/8";
            button2.text = "2/8";
            button3.text = "3/8";
            button4.text = "6/8";
            scoreText.text = score.ToString();
            question = question + 1;
            
        }
        
       
        else if (question == 2)
        {


            if (answer == 2)
            {
                speed = speed + 15;
                score = score + 1;

            }

            else wrongAnswer();
            

            
            questionText.text = "0.25 =";
            button1.text = "1/5";
            button2.text = "2/5";
            button3.text = "1/4";
            button4.text = "1/3";
            scoreText.text = score.ToString();
            question = question + 1;
            
        }


        else if (question == 3)
        {

            if (answer == 3)
            {
                score = score + 1;
                speed = speed + 15;

            }

            else wrongAnswer();
       

            questionText.text = "1/5 =";
            button1.text = "40%";
            button2.text = "20%";
            button3.text = "25%";
            button4.text = "30%";
            scoreText.text = score.ToString();
            question = question + 1;
            

        }

        else if (question == 4)
        {

            if (answer == 2)
            {
                score = score + 1;
                speed = speed + 15;
            }
            else wrongAnswer();
       

            questionText.text = " 1¼ =";
            button1.text = "5/4";
            button2.text = "4/4";
            button3.text = "8/4";
            button4.text = "3/4";
            scoreText.text = score.ToString();
            question = question + 1;
            
        }

        else if (question == 5)
        {

            if (answer == 1)
            {
                score = score + 1;
                speed = speed + 15;
            }
            else wrongAnswer();
            

            questionText.text = "8/3 =";
            button1.text = "½";
            button2.text = "1¼";
            button3.text = "1⅖";
            button4.text = "2⅔";
            scoreText.text = score.ToString();
            question = question + 1;
            
        }
        
        else if (question == 6)
        {

            if (answer == 4)
            {
                score = score + 1;
                speed = speed + 15;
            }
            else wrongAnswer();
           

            questionText.text = "3/4 * 1/3 =";
            button1.text = "3/7";
            button2.text = "3/43";
            button3.text = "3/12";
            button4.text = "9/4";
            scoreText.text = score.ToString();
            question = question + 1;
            
        }

        else if (question == 7)
        {

            if (answer == 3)
            {
                score = score + 1;
                speed = speed + 15;
            }
            else wrongAnswer();

            questionText.text = "1 1/6 * 1/5 =";
            button1.text = "7/11";
            button2.text = "7/30";
            button3.text = "1/30";
            button4.text = "1/11";
            scoreText.text = score.ToString();
            question = question + 1;
            
        }

        else if (question == 8)
        {

            if (answer == 2)
            {
                score = score + 1;
                speed = speed + 15;
            }
            else wrongAnswer();
           
        }
    }

   
    void Update()
    {
        raceCar.velocity = new Vector3(speed, 0, 0);

      
    }

}
