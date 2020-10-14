using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Hangman
    {
        List<string> Words;//list of available words
        char[] Word;//array for word that user should guess
        char[] GuessedWord;//array for word that user

        //creates a new list with words to guess
        public Hangman()
        {
            Words = new List<string>()
       { "blue", "white", "green", "black" };
        }
        // all starting logic (e.g. randomly chooses one word from the list, creates arrays Word and GuessedWord etc.)
        public void NewGame()
        {

            int position = new Random().Next(Words.Count);
            string randomWord = Words[position];
            Word = new char[randomWord.Length];//kuru minesu
            GuessedWord = new char[randomWord.Length];//cik daudz ir atminejisfor (int x = 0; x < word.Length; x++)

            for (int i = 0; i < randomWord.Length; i++)
            {
                Word[i] = randomWord[i];
                GuessedWord[i] = '_';
            }

        }

        //if word is fully guessed or not

        public bool IsWordGuessed()
        {
            bool IsGuessed = true;

            foreach (char letter in GuessedWord)
            {
                if (letter == '_')
                {
                    IsGuessed = false;
                    break;
                }
            }
            return IsGuessed;
        }








        //check if word contains letter and places it in the correct position in the array GuessedWord
        public bool Guess(char letter)
        {
            bool contains = false;

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == letter)
                {
                    GuessedWord[i] = letter;
                    contains = true;
                }
            }
            return contains;
        }
        //returns current situation for word as text(e.g. "W-LL")
        public string GetWord()
        {
            string result = "";
            foreach (char letter in GuessedWord)
            {
                result += letter + " ";

            }
            return result;
        }
    }
}