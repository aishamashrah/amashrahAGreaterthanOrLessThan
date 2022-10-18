//aisha mashrah
//10/18/22
//

bool playAgain = true;
while(playAgain){

Console.WriteLine("Will compare 2 numbers  ");

Console.WriteLine("Enter ur 1st number: ");
string firstNum = Console.ReadLine();

Console.WriteLine("Enter ur 2nd number: ");
string secNum = Console.ReadLine();

int num1 = Convert.ToInt32(firstNum);
int num2 = Convert.ToInt32(secNum);

Console.WriteLine(" ");

if ( num1 > num2 ) {
    Console.WriteLine( num1 + " is greater than " + num2);
    Console.WriteLine( num2 + " is less than " + num1);
} else {
    Console.WriteLine( num1 + " is less than " + num2);
    Console.WriteLine( num2 + " is greater than " + num1);
}
Console.WriteLine(" ");
    Console.WriteLine("Would you like to play again? Yes or No");
    string rePlay = Console.ReadLine();
    if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
        playAgain = true;
        Console.Clear();
        Console.WriteLine( "play agian" );
        Console.WriteLine( " " );
    } 
    if(rePlay == "NO" || rePlay == "no"){
        playAgain = false;
        Console.WriteLine( "thank you" );
    } 
}

