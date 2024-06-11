Console.WriteLine("Enter a paragraph: ");
string paragraph = Console.ReadLine(); // The user enters the paragraph to be analyzed

Console.WriteLine("Enter the banned word: ");
string bannedWord = Console.ReadLine(); // The user enters the banned word

char[] delimiters = {' ', '!', '?', '.', ';', ','};

paragraph = paragraph.ToLower();
string[] words = paragraph.Split(delimiters, StringSplitOptions.RemoveEmptyEntries); // Array with the words from the paragraph 


int numberMostFrequentWord = 0;
string mostFrequentWord = "";

foreach (string word in words) {
    //Console.WriteLine(word);
    int countWords = 0;

    for (int i = 0; i < words.Length; i++){

        if (word == words[i] && word != bannedWord){
            countWords += 1;
        }

        if (numberMostFrequentWord < countWords && word != bannedWord){
            numberMostFrequentWord = countWords;
            mostFrequentWord = words[i];
        }
        
    }
}

Console.WriteLine("Most frequent word: " + mostFrequentWord);
Console.WriteLine("Number of the most frequent word: " + numberMostFrequentWord);


