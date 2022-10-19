/* See https://aka.ms/new-console-template for more information

ARELY MARTINEZ 
OCT 19 2022 2:41 PM 
THIS PROGRAM WILL ASK THE USER TO ENTER NUMBERS 
WORDS OR A MIX OF THE TWOS. ONCE THEY INPUT THIER 
RESPONSE THE PROGRAM WILL DISPLAY THE ORIGINAL 
THEN THE REVERED FORM. AFTER THE PROGRAM WILL ASK 
THE USER IF THEY WANT TO PLAY AGAIN. IF THEY SAY 
'YES' THE PROGRAM WILL RERUN AND 'NO' TO STOP
IF THE USER DOESNT TYPE IN ANY VARIATION OF YES 
OR NO THEN THEY WILL COUNTINE TO ASK A VAILD INPUT 
ONCE THEY DO IT WILL EITHER END OR REPEAT.

PEER REVIEW: NAME -- REVIEW
*/

Console.Clear();
bool playAgain = true;

while(playAgain){
    Console.WriteLine("ENTER NUMBERS/WORDS OR A MIX OF BOTH  EX: hi user890 ");
    string userNum = Console.ReadLine();
    string reverseNum = string.Empty;
    Console.WriteLine(" ");

    Console.WriteLine("YOUR ORIGINAL INPUT: ");
    Console.WriteLine( userNum);
    Console.WriteLine(" ");
    Console.WriteLine("YOUR INPUT BUT REVERESED: ");
    //Console.WriteLine( userNum);

    for(int i = userNum.Length - 1; i >= 0; i--){
        reverseNum += userNum[i];
        
        Console.Write(userNum[i]);
        //Console.Write(reverseNum);
    }
    bool converted = true;
     Console.WriteLine(" ");

    while (converted){
         Console.WriteLine(" ");
        Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN? YES OR NO? ");
        string rePlay = Console.ReadLine().ToUpper();

        if(rePlay == "YES"){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" ){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
        }
    } 
}