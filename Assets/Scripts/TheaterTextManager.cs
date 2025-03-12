using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScreenTextController : MonoBehaviour {
    public TextMeshPro questionText;
    public TextMeshPro[] answerTexts;

    void Start() {
        SetQuestion("What is the capital of France?", new string[] { "Berlin", "Paris", "Madrid", "Rome" });
    }

    public void SetQuestion(string question, string[] answers) {
        questionText.text = question;
        for (int i = 0; i < answers.Length; i++) {
            if (i < answerTexts.Length) {
                answerTexts[i].text = answers[i];
            }
        }
    }
}


//What makes Viycanze Apartments a great choice for visitors staying in Miami?

//A) They are located underwater for a unique aquatic experience.
//B) They combine modern comfort with a prime city location. ANSWER
//C) They are exclusively for long-term residents and not available for vacation stays.
//D) They are the tallest skyscrapers in Florida.

//Which nickname is commonly associated with Miami?

//A) The Magic City ANSWER
//B) The Windy City
//C) The Big Apple
//D) The Mile-High City

//Which European nation was the first to colonize the area now known as Miami?

//A) France
//B) Spain ANSWER
//C) Portugal
//D) England

//Approximately how many tourists visit Miami each year?

//A) 18 million
//B) 21 million
//C) 23 million
//D) 25 million ANSWER
