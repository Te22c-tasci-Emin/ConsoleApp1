
    
        // STARTA programmet

        // SKAPA en array 'numbers' med storlek 5 //initialice the variable assignar variabeln
        int[] numbers = new int[5]{50,76,8787,8787,3242};
        
        // TILLDELA värden till arrayen
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
//en bra anledning till varför man använder arrays eller listor är för att om man ska loopa genom en samling av samma värde. Arrays är lik en lista som består av en samling 
        // FÖR varje index i arrayen från 0 till arrayens längd - 1
        for (int i = 0; i < numbers.Length; i++)
        {
            // SKRIV UT värdet på numbers[i]
            Console.WriteLine(numbers[i]+10);
        }
        
        Console.ReadLine();
        // SLUT FÖR

        // STOPPA programmet
    

