//labloops
//Oppgave 1
//Skriv kode som ber bruker om å taste inn sitt navn. Lagre denne i en variabel av typen string. (Fordi det er tekst). Bruk Console.ReadLine();
//Bruk en foreach loop til å skrive ut et og et tegn i denne variabelen.
Console.WriteLine("Please write your name");
var name = Console.ReadLine();
foreach(char s in name)
{
    Console.WriteLine(s);
    Thread.Sleep(100)
;
}
//Oppgave 2
//Lag en for loop som skriver ut 5 stykk av dette tegnet *
for(int i= 0; i<5; i++)
{
    Console.WriteLine("*");

}
//Lab metoder

//oppgave1
//Kall på metoden Addisjon. Husk å "sende" med tallene.
int Add(int i, int y)
{
    return i + y;
}
var sum = Add(1, 5);
Console.WriteLine(sum);
//oppgave2
//lag en metode som tar imot 2 tall, altså 2 parametre, som multipliserer 2 tall. Deretter kall på denne metoden. (Blir nesten det samme som metoden Addisjon)
//Velg selv et passende navn for metoden. Metodenavn skal alltid ha stor forbokstav.
int Multiply(int i, int y)
{
    return i * y;
}
var result = Multiply(1, 5);
Console.WriteLine(sum);
//oppgave 3
//Hva er en static metode? Hva er forskjellen på det og en non static?
//i en static metode kan du ikke legge til nye variabler eller erklære nye objekter


//oppgave 4
//Metoder som returnerer noe
//Lag en metode som returnerer noe. Google c# methods og return etc, for å finne en snippet
//Kall på metoden og ta vare på verdien som blir returnert.
string Concat(string s, string y)
{
    return s + y;
}
var reslt = Concat("hello", "hello2");
Console.WriteLine(reslt);
