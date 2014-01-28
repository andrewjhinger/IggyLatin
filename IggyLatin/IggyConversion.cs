using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace IggyLatin
{
    /*
    * Iggy Latin Rules: 
    * 
    * 1. Vowels including y (a,e,i,o,u,y) are prepended with ig
    * 2. Append all words ending in consonant (except y) with iggy
    * 2. Trailing y replaced with iggy
    * 3. Append all words ending in vowel with ggy
    *
    * */

    public static class IggyConversion
    {
        // Private class variables
        private static readonly char[] _prependList = "yiaeou".ToCharArray();
        private static readonly char[] _appendList = "aeiou".ToCharArray();
        private static readonly char[] _appendSpecialList = "y".ToCharArray();
        private static readonly char[] _appendttList = "t".ToCharArray();
        private static readonly char[] _appendzzList = "z".ToCharArray();
        private static readonly string _prependText = "ig";
        private static readonly string _appendText = "ggy";
        private static readonly string _appendttText = "t";
        private static readonly string _appendzzText = "z";
        private static readonly string _appendSpecialText = "iggy";


        // String methods
        public static string ConvertUsingString(string sentence)
        {
            string convertedSentence = string.Empty;

            // Make sure we have something to convert
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                // Parse out each word
                string word = "";
                for (int position = 0; position < sentence.Length; position++)
                {
                    string character = sentence.Substring(position, 1);
                    if (!char.IsWhiteSpace(character, 0))
                        word += character;

                    if (char.IsWhiteSpace(character, 0) || position == sentence.Length - 1)
                    {
                        convertedSentence += ConvertWordUsingString(word);
                        if (position < sentence.Length - 1) convertedSentence += character;
                        word = string.Empty;
                    }
                }
            }

            return convertedSentence;
        }

        private static string ConvertWordUsingString(string word)
        {
            string convertedWord = string.Empty;

            // Make sure we have something to convert
            if (!string.IsNullOrWhiteSpace(word))
            {
                // Convert each character, with special handling for last character
                for (int position = 0; position < word.Length; position++)
                {
                    string character = word.Substring(position, 1);
                    if (character.ToLower().IndexOfAny(_prependList) >= 0)
                    {
                        // "Vowels"
                        if (position < word.Length - 1)
                            // Prepend
                            convertedWord += _prependText + character;
                        else if (character.ToLower().IndexOfAny(_appendSpecialList) >= 0)
                            // Append special
                            convertedWord += _appendSpecialText;
                        else if (character.ToLower().IndexOfAny(_appendList) >= 0)
                            // Append
                            convertedWord += character + _appendText;
                    }
                    else if (character.ToLower().IndexOfAny(_appendttList) >= 0)
                    {
                        convertedWord += character + _appendttText;
                    }

                    else if (character.ToLower().IndexOfAny(_appendzzList) >= 0)
                    {
                        convertedWord += character + _appendzzText;
                    }

                    else
                    {
                        // "Consonants"
                        if (position < word.Length - 1)
                            // Append
                            convertedWord += character;
                        else
                            // Append special
                            convertedWord += character + _appendSpecialText;
                    }
                }
                // Fix first character case
                if (word.Substring(0, 1).Equals(word.Substring(0, 1).ToUpper(), StringComparison.Ordinal))
                    convertedWord = char.ToUpper(convertedWord[0]) + convertedWord.Substring(1);

            }
            return convertedWord;
        }

        // StringBuilder methods
        public static string ConvertUsingStringBuilder(string sentence)
        {
            StringBuilder convertedSentence = new StringBuilder(sentence.Length);

            // Make sure we have something to convert
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                // Parse out each word
                StringBuilder word = new StringBuilder();
                for (int position = 0; position < sentence.Length; position++)
                {
                    string character = sentence.Substring(position, 1);
                    if (!char.IsWhiteSpace(character, 0))
                        word.Append(character);

                    if (char.IsWhiteSpace(character, 0) || position == sentence.Length - 1)
                    {
                        convertedSentence.Append(ConvertWordUsingStringBuilder(word.ToString()));
                        if (position < sentence.Length - 1) convertedSentence.Append(character);
                        word.Clear();
                    }
                }
            }
            return convertedSentence.ToString();
        }

        private static string ConvertWordUsingStringBuilder(string word)
        {
            string convertedWord = string.Empty;

            // Make sure we have something to convert
            if (!string.IsNullOrWhiteSpace(word))
            {
                StringBuilder workingWord = new StringBuilder(word.Substring(0, word.Length - 1));
                // Replace all "vowels" except skip last character (special handling)
                foreach (char ch in _prependList)
                    workingWord.Replace(ch.ToString(), _prependText + ch);
                foreach (char t in _appendttList)
                    workingWord.Replace(t.ToString(), _appendttText + t);
                foreach (char z in _appendzzList)
                    workingWord.Replace(z.ToString(), _appendttText + z);

                // Replace last character
                string lastCharacter = word.Substring(word.Length - 1, 1);
                if (lastCharacter.IndexOfAny(_appendSpecialList) >= 0)
                    workingWord.Append(_appendSpecialText);
                else if (lastCharacter.IndexOfAny(_appendList) >= 0)
                    workingWord.Append(lastCharacter + _appendText);
                else
                    workingWord.Append(lastCharacter + _appendSpecialText);

                // Fix first character case
                if (word.Substring(0, 1).Equals(word.Substring(0, 1).ToUpper(), StringComparison.Ordinal))
                    workingWord[0] = char.ToUpper(workingWord[0]);

                convertedWord = workingWord.ToString();
            }
            return convertedWord;
        }

        // Convert using regular expressions
        public static string ConvertUsingRegularExpressions(string sentence)
        {
            // Make sure we have something to convert
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                // Step 1: Prepend all vowels and y with ig not at end of word
                string matchPattern = @"[aeiouy](?!\b)";
                string replacePattern = _prependText + @"$&";
                sentence = Regex.Replace(sentence, matchPattern, replacePattern, RegexOptions.IgnoreCase);

                // Step 2: Replace all words ending in y with iggy
                matchPattern = @"[y]\b";
                replacePattern = _appendSpecialText;
                sentence = Regex.Replace(sentence, matchPattern, replacePattern, RegexOptions.IgnoreCase);

                // Step 3: Replace all words ending in vowel with vowel+ggy
                matchPattern = @"[aeiou]\b";
                replacePattern = @"$&" + _appendText;
                sentence = Regex.Replace(sentence, matchPattern, replacePattern, RegexOptions.IgnoreCase);

                // Step 4: Replace all words not ending in vowels or y with iggy
                matchPattern = @"[^aeiouy\W]\b";
                replacePattern = @"$&" + _appendSpecialText;
                sentence = Regex.Replace(sentence, matchPattern, replacePattern, RegexOptions.IgnoreCase);

                // Step 5: Replace all t with two tt.
                matchPattern = @"[t](?!\b)";
                replacePattern = @"$&" + _appendttText;
                sentence = Regex.Replace(sentence, matchPattern, replacePattern, RegexOptions.IgnoreCase);

                // Step 5: Replace all z with two zz.
                matchPattern = @"[z](?!\b)";
                replacePattern = @"$&" + _appendttText;
                sentence = Regex.Replace(sentence, matchPattern, replacePattern, RegexOptions.IgnoreCase);
            }
            return sentence;
        }
    }
}