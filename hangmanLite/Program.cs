//hangman lite

//ALGORITHM

//1.1 A random word is chosen from the word list.
//1.2 The randomly selected word is printed on the screen in encrypted form.
//1.3 The user's life is printed on the screen.
//1.4 The user's life depends on the length of the word.
//1.5 The user is prompted to enter a letter.
//1.6 If the letter entered by the user is not in the word, the user's life will decrease.
//1.7 Go to step 1.5.
//1.8 If the letter entered by the user is in the word, that letter is opened in the word.
//1.9 If the user knows the whole word, "Congratulations, you know." is printed.
//2   If the user does not know the word, "You didn't know, try again" is printed on the screen.


//basit adam asmaca

//ALGORİTMA

//1.1 Kelime listesinden rastgele bir kelime seçilir.
//1.2 Rastgele seçilen kelime ekrana şifreli bir şekilde yazdırılır.
//1.3 Kullanıcının canı ekrana yazdırılır.
//1.4 Kullanıcının canı kelimenin uzunluğuna göre değişir.
//1.5 Kullanıcıdan bir harf girmesi istenir.
//1.6 Eğer kullanıcının girdiği harf kelimenin içerisinde yoksa kullanıcının canı azalır.
//1.7 Adım 1.5'e git.
//1.8 Eğer kullanıcının girdiği harf kelimede varsa kelimede o harf açılır.
//1.9 Eğer kullanıcı tüm kelimeyi bilirse ekrana "Tebrikler bildiniz." yazdırılır.
//2   Eğer kullanıcı kelimeyi bilemezse ekrana "congratulations you know" yazdırılır.



Console.WriteLine("Guess the word :)");
string[] words = new string[5]
{
             "texsas", "kaliforniya", "hawaii", "alaska", "ohio" // case sensitive
};
Random random = new Random();
int randomIndex = random.Next(0, words.Length);
string word = words[randomIndex];

string result = "";
for (int i = 0; i < word.Length; i++)
{
    result += "*"; //Another Method => result = result+ "*";
}


Console.WriteLine(result);
char[] resultLetters = new char[result.Length];

for (int i = 0; i < resultLetters.Length; i++)
{
    resultLetters[i] = result[i];
}
int life = word.Length;

bool didKnow = false;

do
{
    Console.Write("Please enter a letter" + " (Life: " + life + "): ");
    char letter = char.Parse(Console.ReadLine());
    for (int i = 0; i < word.Length; i++)
    {

        if (letter == word[i])
        {
            resultLetters[i] = letter;

        }
    }

    int index = word.IndexOf(letter);
    if (index >= 0)
    {
        resultLetters[index] = word[index];
    }
    else
    {
        life--;
    }
    result = "";
    foreach (var resultLetter in resultLetters)
    {
        result += resultLetter; //Another Method => result = result+ resultLetter;
    }
    Console.WriteLine(result);

    if (!result.Contains("*"))
    {
        didKnow = true;

    }
    //result = "";

}
while (life > 0 && !didKnow);

if (!didKnow)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You didn't know, try again.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("congratulations you know.");
    Console.ResetColor();
}
Console.ReadLine();