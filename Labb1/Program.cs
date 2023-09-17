using System;

Console.Write("Mata in ett tal: ");
string userInput = Console.ReadLine();
long sumOfInput = 0;
highlightStrings(userInput);

void highlightStrings(string input)
{

    // En loop som går igenom varje char i strängen
    for (int startIndex = 0; startIndex < userInput.Length; startIndex++)
    {


        // Tar emot första siffran 
        char firstChar = userInput[startIndex];
        
        // Kontrollera om första siffran är en siffra
        if (char.IsDigit(firstChar))
        {
            // En bool som kollar om första bokstaven har använts innan
            bool firstCharUsed = false;
            
            // Om det är en siffra. Loopa igenom igen och hitta när samma siffra inträffar igen
            for (int endIndex = startIndex + 2; endIndex < userInput.Length; endIndex++)
            {
                // Ta emot den andra siffran i en variabel
                char lastChar = userInput[endIndex];
                // Om den siffran är en siffra och är samma som "firstChar"
                if (char.IsDigit(lastChar) && firstChar == lastChar && !firstCharUsed)
                {
                    // Hittills är char nummer
                    bool isANumber = true;
                    // Gör en loop som går från startIndex till matchande endIndex
                    for (int i = startIndex + 1; i < endIndex; i++)
                    {
                        // Om alla chars inte är nummer
                        if (!char.IsDigit(userInput[i]))
                        {
                            // Gör isANumber till falskt och hoppa tillbaka ur loopen
                            isANumber = false;
                            break;
                        }
                    }
                    // Om alla är siffror
                    if (isANumber)
                    { 
                    printHighlightStrings(userInput, startIndex, endIndex);
                        long number = long.Parse(userInput.Substring(startIndex, endIndex - startIndex + 1));
                        sumOfInput += number;
                       firstCharUsed = true;
                        
                        
                    }
                    





                }
               

            }

        }
        

    }






    Console.ResetColor();
    }
void printHighlightStrings(string input, int startIndex, int endIndex) {
    
    // Om de loopade siffrorna är mellan och start och endindex
    // Loopa igenom igen och sätt färg på de loopade siffrorna
    for (int changeColor = 0; changeColor < userInput.Length; changeColor++)
        {

            if (changeColor >= startIndex && changeColor <= endIndex)
            {
                 Console.ForegroundColor = ConsoleColor.Green;
            
            }
            else
            {
                 Console.ResetColor();
            }
            // Skriv ut
            Console.Write(userInput[changeColor]);
        }
        // Delar upp varje sträng
        Console.WriteLine();
        

    }
Console.WriteLine();
Console.WriteLine("Summan av dem färgade strängarna är: " + sumOfInput);






