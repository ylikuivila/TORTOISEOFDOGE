
class Ohjelma
{
    static void Main(string[] args)
    {
        string ChoiceInput = "WAAAAAAAAAAGHHH";
        int Computer = -1;
        System.Random r = new System.Random();
        int PlayerOne = -10;
        string EndChoice = "WAAAAAGHHHH!!!";
        int PlayedGames = 0;
        int Victories = 0;
        int Ties = 0;
        int Losses = 0;
        int WAAAGHS = 0;

    InputUudestaan:
        System.Console.WriteLine("Hei! Pelataan! Valitse Kivi, Paperi tai Sakset.");
        System.Console.WriteLine("As in: Kirjoita Kivi; Paperi; Sakset. Tai WAAAGH");
        ChoiceInput = System.Console.ReadLine();


        ChoiceInput = ChoiceInput.ToLower().Trim(); /* Käyttöliittymän suunnittelua; Muista - käyttäjä voi tehrä ihan mitä sattuu. 
                                                       * Pitää tehdä käyttäjäystävällistä koodia sekä pelejä */


        if (ChoiceInput == "Kivi" || ChoiceInput == "kivi")
        {
            // Tietokoneen arvo 0 vastaa tätä
            System.Console.WriteLine("Valitsit Kiven!");
            PlayerOne = 0;
        }
        else if (ChoiceInput == "Paperi" || ChoiceInput == "paperi")
        {
            // Tietokoneen arvo 1 vastaa tätä
            System.Console.WriteLine("Valitsit Paperin!");
            PlayerOne = 1;

        }
        else if (ChoiceInput == "Sakset" || ChoiceInput == "sakset")
        {
            // Tietokoneen arvo 2 vastaa tätä
            System.Console.WriteLine("Valitsit Sakset!");
            PlayerOne = 2;
        }
        else if (ChoiceInput == "WAAAGH" || ChoiceInput == "waaagh")
        {
            // Tietokoneen arvo 3 vastaa tätä
            System.Console.WriteLine("Olet kutsumassa Ork Hordea. Protokolla 501:n mukaan PATRIOT ACTista inkvisitiolle on ilmoitettu.");
            PlayerOne = 3;
        }
        else
        {
            System.Console.WriteLine("Väärä valinta. Yritä uudestaan.");
            System.Console.ReadKey();
            goto InputUudestaan;
        }
        /* Kotitehtävä: Tee vertailulausekkeet loppuun; yritä tehrä nättiä ja katso että toimii.
         * Manuaalisesti testaa sen toiminta.
         0 = Kivi
         1 = Paperi
         2 = Sakset 
         3 = WAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGH! */

        Computer = r.Next(4);

        if (Computer == PlayerOne)
        {
            System.Console.WriteLine("Tasapeli! Jumankekka!");
            Ties++;
            PlayedGames++;
            System.Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");


            EndChoice = System.Console.ReadLine();
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;

            }
        }
        else if (PlayerOne == 0 && Computer == 2)
        {
            System.Console.WriteLine("Voitit!");
            Victories++;
            PlayedGames++;
            System.Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");


            EndChoice = System.Console.ReadLine();
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;

            }
        }
        else if (PlayerOne == 1 && Computer == 0)
        {
            System.Console.WriteLine("Voitit!");
            Victories++;
            PlayedGames++;
            System.Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");


            EndChoice = System.Console.ReadLine();
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;

            }
        }
        else if (PlayerOne == 2 && Computer == 1)
        {
            System.Console.WriteLine("Voitit!");
            Victories++;
            PlayedGames++;
            System.Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");


            EndChoice = System.Console.ReadLine();
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;

            }
        }
        else if (PlayerOne == 3 && Computer == 0)
        {
            System.Console.WriteLine("WAAAAGH!!!! HÄVISITTE!");
            WAAAGHS++;
            Losses++;
            PlayedGames++;
            System.Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");


            EndChoice = System.Console.ReadLine();
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;

            }
        }
        else if (PlayerOne == 3 && Computer == 1)
        {
            System.Console.WriteLine("WAAAAGH!!!! HÄVISITTE!");
            WAAAGHS++;
            Losses++;
            PlayedGames++;
            System.Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");


            EndChoice = System.Console.ReadLine();
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;

            }
        }
        else if (PlayerOne == 3 && Computer == 2)
        {
            System.Console.WriteLine("WAAAAGH!!!! HÄVISITTE!");
            WAAAGHS++;
            Losses++;
            PlayedGames++;
            System.Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");


            EndChoice = System.Console.ReadLine();
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;

            }
        }
        else if (PlayerOne == 3 && Computer == 2)
        {
            System.Console.WriteLine("WAAAAGH!!!! HÄVISITTE!");
            WAAAGHS++;
            Losses++;
            PlayedGames++;
            System.Console.WriteLine("Haluatko pelata uudestaan? Vastaa kyllä tai ei.");
            
           
            EndChoice = System.Console.ReadLine();
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;

            }
        }
        else
        {
           
            System.Console.WriteLine("Hävisit. Haluatko pelata uudestaan? Vastaa kyllä tai ei.");
            PlayedGames++;
            EndChoice = System.Console.ReadLine();
          
            EndChoice = EndChoice.ToLower().Trim();
            if (EndChoice == "kyllä")
            {
                goto InputUudestaan;
            }
            else
            {
                goto Tilastot;
               
            }
            
        }

        Tilastot:
        System.Console.WriteLine("Tilastot:");
        System.Console.WriteLine("Pelattuja pelejä: " + PlayedGames);
        System.Console.WriteLine();
        System.Console.WriteLine("Voitot: " + Victories);
        System.Console.WriteLine("Tappiot: " + Losses);
        System.Console.WriteLine("Tasapelit: " + Ties);
        System.Console.WriteLine();
        System.Console.WriteLine("WAAAAGH:ien määrä:" + WAAAGHS);
        System.Console.ReadKey();
        /* Kotitehtävä: Ymmärrä, sisäistä; rakenna ja laajenna tätä peliä. Sen kautta tullaan viimeistelemään kurssi.
         * Esim. High-score taulukot, kellotus; aikahaaste; easter eggit. PISTÄ SE PRINTTAAMAAN TIETOKONEEN SAAMA VASTINE! 
         * Lisää peliin stastiikkaa; voitot, häviöt; tasapelit; Interference from the imperial inquisition */
    }
}
