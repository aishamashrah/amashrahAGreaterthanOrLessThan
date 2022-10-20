//aisha mashrah
//10/18/22
//
//Peer Review By: Kenneth Fujimura

//The program works and it does the job. The only thing it's missing is some data validation. If you plug in numbers that have decimals, or other string inputs, the program crashes. If you want to explore how to get some data validation to work, you can use a TryParse like we did earlier the class. I can walk you through that if you'd like/have time. But I don't know how necessary it will be to do so; I would ask Ken Martinez what he wants. 

//Also, make sure you follow the Submission Guidelines in the LMS and for the specific assignment. I think we need a description of the program in your README file, and you need to finish filling out the information comments at the top of the vs code.

//Other than that things work well, the code was easy to follow, etc.

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

