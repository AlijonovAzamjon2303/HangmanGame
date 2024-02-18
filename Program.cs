// book
string correctAnswer = "Book";
int fails = 0;
Console.WriteLine("Assalomu alaykum, Hangman o'yiniga xush kelibsiz!");
Console.WriteLine("Sizga savol beriladi va siz ularga javob topish orqali");
Console.WriteLine("yashiringan so'zni topishingiz kerak bo'ladi\n");

Console.WriteLine("\"----\" ko'rinishidagi so'zni topishingiz kerak bo'ladi");
Console.WriteLine("Qani unda boshladik!\n");
Thread.Sleep(3000);

string word = "";
word += Hangman("Ingliz alifbosidagi 2-harf ", "B");

word += Hangman("Nolga o'xshash harf ", "o");

word += Hangman("Ingliz tilida qanday 2 ta bir xil harf kelsa \'u\' shaklida o'qiladi ", "o");

word += Hangman("Dengizda suza oladigan qurilma nomi qanday harfdan boshlanadi", "k");

Console.WriteLine(word + " so'zini muvafaqiyatli topdingiz!");

string Hangman(string question, string answer)
{
    string userInput;
    do
    {
        Console.Clear();
        Status(correctAnswer, word);
        Console.WriteLine(question);
        Console.Write("=>"); userInput = Console.ReadLine();
        if(userInput.ToLower() != answer.ToLower())
        {
            Console.WriteLine("Sizning javobingiz xato, qaytadan urinib ko'ring!\n");
            fails++;
            Thread.Sleep(2000);
        }
    }while(userInput.ToLower() != answer.ToLower());
    Console.Clear();
    Console.WriteLine("Sizning javobingiz to'g'ri\n");
    return answer;
}

void Status(string correctAnswer, string answer)
{
    Console.Clear();
    Console.WriteLine("Sizning statusingiz : ");
    Console.Write(answer);
    for(int i = 0; i < correctAnswer.Length - answer.Length; i++)
    {
        Console.Write('-');
    }
    Console.WriteLine("\n");
}